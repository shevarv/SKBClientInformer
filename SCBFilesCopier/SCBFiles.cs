using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ShevarvProject.SKBClientInformerDataBaseNamespace;

namespace SCBFilesCopier
{
    public class SCBFiles
    {
        //Функція копіювання
	public int Copy (string source, string destination)
        {
            try
            {
                File.Copy(source, destination,true);
                return 0;
            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }

        public int Move (string source, string destination)
        {
            try
            {
                File.Move(source, destination);
                return 0;
            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }

        public int CreateDirectory (string path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);
                if (!di.Exists)
                {
                    di = Directory.CreateDirectory(path);
                }
                return 0;
            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }


        public int RemoveDirectory(string path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);
                if (di.Exists)
                {
                   Directory.Delete(path, true);
                }
                return 0;
            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }

        public List<string> UpdateClientList()
        {
            List<string> lst = new List<string>();
            SqlExpression sq = new SqlExpression();
            sq.SelectData("", "", "", "");
            DataSet ds = new DataSet();
            ds.DataSetName = "СхемаКБ";
            sq.Dt.TableName = "КористувачіКБ";
            ds.Tables.Add(sq.Dt);
            foreach (DataRow rows in sq.Dt.Rows)
            {
                
                lst.Add((string)rows.ItemArray.GetValue(6));
            }
            ds.WriteXml("cbclients.xml");
            return lst;
        }

        public void CreateDirectoryForClient(char baseDrive)
        {
            List<string> lst = UpdateClientList();
            foreach (string path in lst)
            {
                CreateDirectory(baseDrive + path.Substring(1,path.Length-1));
            }

        }

    }
}
