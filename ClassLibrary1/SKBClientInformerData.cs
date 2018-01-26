using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace ShevarvProject.SKBClientInformerDataBaseNamespace
{
    /// <summary>
    /// Клас для констроювання SQL запиту до бази даних
    /// </summary>
    public class SqlExpression
    {
        /// <summary>
        /// SQL запит
        /// </summary>
        public string SqlSentense { get; private set; }

        /// <summary>
        /// Властивість для запису та зчитування результатів SQL запиту
        /// </summary>
        public DataTable Dt { get; private set; }

        private static string SelColumn = @"select a.client_id  as ""Код клієнта в СКБ"",
                                        b.client_ref as ""Код клієнта"", 
                                        b.short_name ""Назва клієнта"",
                                        a.wrk_access as ""Доступ"",
                                        a.pay_access as ""Платежі"",
                                        a.crypto_connect as ""Крипто"",
                                        a.out_dir as ""Вихідний каталог"",
                                        a.note as ""Дод інформація""";
        private static string FromTable = @" from usr_cbs_clients a , clnt_names_ b, clnt_key_par t";
        private static string WhereCondition = @" where a.odb_ref = b.client_ref and b.client_ref=t.client_ref and t.par_type in ('TIN','OKPO')";
        private static string OrderCondition = " order by b.client_ref";

        public SqlExpression()
        {
            SqlSentense = "";
        }

        private void SetSqlExp ()
        {
            StringBuilder st = new StringBuilder(SelColumn);
            SqlSentense = st.Append(FromTable).Append(WhereCondition).Append(OrderCondition).ToString();
        }


        /// <summary>
        /// Формує SQL запит і передає його на виконання
        /// </summary>
        /// <param name="selParams">параметри для пошуку 0 - по Коду клієнта, 1 - по імені, 2 - по ІПН(ЄДРПОУ), 3 - по номеру СКБ</param>
        /// <returns></returns>
        public async Task SelectData(params string[] selParams)
        {

            if (selParams[0] != "") WhereCondition += " and b.client_ref=" + selParams[0];
            if (selParams[1] != "") WhereCondition += " and UPPER(b.short_name) like '%" + selParams[1].ToUpper() + "%'";
            if (selParams[2] != "") WhereCondition += " and t.par_value='" + selParams[2] + "'";
            if (selParams[3] != "") WhereCondition += " and a.client_id=" + selParams[3];

            SetSqlExp();
            DataBase db = new DataBase("ODB", "opcbank", "bankopc11");
            Dt = await db.SelectDataTableAsync(this);
        }

    }

   
    
    
    
    
    
    
    
    
    
    
    /// <summary>
    /// Клас для роботи з БД
    /// </summary>
    public class DataBase
    {
        private string dataSource;
        private string userId;
        private string password;

        /// <summary>
        /// Конструктор класу ініціалізує члени класу
        /// </summary>
        /// <param name="DataSource">Alias БД</param>
        /// <param name="UserId">Імя користувача</param>
        /// <param name="Password">Пароль користувача</param>
        public DataBase(string DataSource, string UserId, string Password)
        {
            this.dataSource = DataSource;
            this.userId = UserId;
            this.password = Password;
        }

        /// <summary>
        /// Повертає об'єкт типу OleDbConnection у разі успішного зєднання з БД інакше - NULL
        /// </summary>
        protected OracleConnection Connection()
        {
            try
            {
                return new OracleConnection("User Id = " + userId + ";Password= " + password + "; Data Source = " + dataSource + ";");
            }
            catch (Exception e)
            {
                //                Log.Write(new string[] { this.UserId, "Error", @"Не можливо з'єднатися з базою: ", e.Message });
                return null;
            }
        }

        /// <summary>
        /// Повертає результат SQL запиту в форматі  DataTable
        /// </summary>
        /// <param name="sqlSelect">SQL запит</param>
        public DataTable SelectDataTable(SqlExpression sqlSelect)
        {
            DataTable dt = new DataTable();
            OracleConnection appConn = this.Connection();
            try
            {
                appConn.Open();
                OracleDataAdapter adatter = new OracleDataAdapter(sqlSelect.SqlSentense, appConn);
                adatter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                //                Log.Write(new string[] { this.UserId, "Error", "Не можливо виконати запрос: ", e.Message });
                return dt;
            }
            finally
            {
                appConn.Close();
                appConn.Dispose();
            }
        }
        /// <summary>
        ///  Повертає результат SQL запиту в форматі  DataTable (Асинхронний варіант)
        /// </summary>
        /// <param name="sqlSelect">SQL запит</param>
        public async Task<DataTable> SelectDataTableAsync(SqlExpression sqlSelect)
        {
            return await Task.Run(() =>
            {
                DataTable dt = new DataTable();
                return dt = SelectDataTable(sqlSelect);
            });

        }

    }
}
