using MySqlConnector;
using NPoco;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsChElementsNPoco
{
    internal class DBHelper
    {
        private static string ConnectionString { get; } = ConfigurationManager.ConnectionStrings["mariadb"].ConnectionString;

        public static List<ChElement> LoadElements()
        {
            List<ChElement> list = new();
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using Database db = new Database(connection);
                connection.Open();
                string sql = "order by ordnungszahl";
                list = db.Fetch<ChElement>(sql);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return list;
        }
        
        public static void AddElement(ChElement element)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using Database db = new Database(connection);
                connection.Open();
                db.Insert(element);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        
        public static void UpdateElement(ChElement element)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using Database db = new Database(connection);
                connection.Open();
                db.Update(element);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        
        public static void DeleteElement(ChElement element)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using Database db = new Database(connection);
                connection.Open();
                db.Delete(element);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
