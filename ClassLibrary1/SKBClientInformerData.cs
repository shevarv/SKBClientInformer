using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;


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
        /// Секція SELECT SQL запиту 
        /// </summary>
        public string SelColumn { get; private set; }

        /// <summary>
        /// Секція FROM SQL запиту 
        /// </summary>
        public string FromTable { get; private set; }

        /// <summary>
        /// Секція WHERE SQL запиту 
        /// </summary>
        public string WhereCondition { get; private set; }

        /// <summary>
        /// Секція ORDER SQL запиту 
        /// </summary>
        public string OrderCondition { get; private set; }

        /// <summary>
        /// Секція GROUP BY SQL запиту 
        /// </summary>
        public string GroupCondition { get; private set; }

        /// <summary>
        /// Властивість для запису та зчитування результатів SQL запиту
        /// </summary>
        public DataTable Dt { get; private set; }

        //public SqlExpression()
        //{
        //    SelColumn = "";
        //    FromTable = "";
        //    WhereCondition = "";
        //    OrderCondition = "";
        //    GroupCondition = "";
        //    SqlSentense = "";
        //}

        //// Констуктор для формування SQL запит формату  SELECT .. FROM
        //public SqlExpression(string columns, string tables)
        //{
        //    SelColumn = columns;
        //    FromTable = tables;
        //    StringBuilder st = new StringBuilder(SqlSentense);
        //    SqlSentense = st.Append(SelColumn).Append(FromTable).ToString();
        //}

        //// Констуктор для формування SQL запит формату  SELECT .. FROM .. WHERE
        //public SqlExpression(string columns, string tables, string whereCond) : this(columns, tables)
        //{
        //    WhereCondition = whereCond;
        //    StringBuilder st = new StringBuilder(SqlSentense);
        //    SqlSentense = st.Append(WhereCondition).ToString();
        //}

        //// Констуктор для формування SQL запит формату  SELECT .. FROM .. WHERE .. ORDER BY
        //public SqlExpression(string columns, string tables, string whereCond, string orderCond)
        //    : this(columns, tables, whereCond)
        //{
        //    OrderCondition = orderCond;
        //    StringBuilder st = new StringBuilder(SqlSentense);
        //    SqlSentense = st.Append(OrderCondition).ToString();
        //}

        //// Констуктор для формування SQL запит формату  SELECT .. FROM .. WHERE .. ORDER BY .. GROUP BY
        //public SqlExpression(string columns, string tables, string whereCond, string orderCond, string groupCond)
        //    : this(columns, tables, whereCond, orderCond)
        //{
        //    GroupCondition = groupCond;
        //    StringBuilder st = new StringBuilder(SqlSentense);
        //    SqlSentense = st.Append(GroupCondition).ToString();
        //}

        public SqlExpression(string columns = "", string tables = "", string whereCond = "", string orderCond = "", string groupCond = "")
        {
            SelColumn = columns;
            FromTable = tables;
            WhereCondition = whereCond;
            OrderCondition = orderCond;
            GroupCondition = groupCond;
            SqlSentense = "";
        }

        private void SetSqlExp ()
        {
            StringBuilder st = new StringBuilder(SelColumn);
            SqlSentense = st.Append(FromTable).Append(WhereCondition).Append(OrderCondition).Append(GroupCondition).ToString();
        }


        /// <summary>
        /// Формує SQL запит і передає його на виконання
        /// </summary>
        /// <param name="selParams">параметри для пошуку 0 - по Коду клієнта, 1 - по імені, 2 - по ІПН(ЄДРПОУ), 3 - по номеру СКБ</param>
        /// <returns></returns>
        public async Task SelectData(params string[] selParams)
        {
            SelColumn = @"select a.client_id  as ""Код клієнта в СКБ"",
                                        b.client_ref as ""Код клієнта"", 
                                        b.short_name ""Назва клієнта"",
                                        a.wrk_access as ""Доступ"",
                                        a.pay_access as ""Платежі"",
                                        a.crypto_connect as ""Крипто"",
                                        a.note as ""Дод інформація""";
            FromTable = @" from usr_cbs_clients a , clnt_names_ b, clnt_key_par t";
            WhereCondition = @" where a.odb_ref = b.client_ref and b.client_ref=t.client_ref and t.par_type in ('TIN','OKPO')";

            if (selParams[0] != "") WhereCondition += " and b.client_ref=" + selParams[0];
            if (selParams[1] != "") WhereCondition += " and UPPER(b.short_name) like '%" + selParams[1].ToUpper() + "%'";
            if (selParams[2] != "") WhereCondition += " and t.par_value='" + selParams[2] + "'";
            if (selParams[3] != "") WhereCondition += " and a.client_id=" + selParams[3];

            OrderCondition = " order by b.client_ref";
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
        public string DataSource { get; }

        private string userId;
        public string UserId { get; }

        private string password;
        public string Password { get; }

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
        /// <returns></returns>
        protected OleDbConnection Connection()
        {
            try
            {
                return new OleDbConnection("Provider=MSDAORA;Data Source=" + this.dataSource + ";User ID=" + this.userId + ";Password=" + this.password + ";Unicode=True");
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
        /// <returns></returns>
        public DataTable SelectDataTable(SqlExpression sqlSelect)
        {
            DataTable dt = new DataTable();
            OleDbConnection appConn = this.Connection();
            try
            {
                appConn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(sqlSelect.SqlSentense, appConn);
                adapter.Fill(dt);
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
            }
        }
        /// <summary>
        ///  Повертає результат SQL запиту в форматі  DataTable (Асинхронний варіант)
        /// </summary>
        /// <param name="sqlSelect">SQL запит</param>
        /// <returns></returns>
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
