using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace CompSoftwareMastery
{
    public class SqliteDataAccess
    {


        private static string LoadConnectionString(string id = "CompStore")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }




        public static List<DatabaseModel> LoadCategories(string query)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<DatabaseModel>(query, new DynamicParameters());
                return output.ToList();
            }
        }



        public static void SaveCategories(DatabaseModel category)
        {
            //not to be used
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Insert Into Categories (yada yada test stuff out)", category);
            }
        }




    }
}
