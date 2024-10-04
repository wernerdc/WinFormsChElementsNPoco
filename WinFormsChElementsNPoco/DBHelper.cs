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
    // Database helper class
    // using MySqlConnector as DB-Driver and NPoco ORM
    internal abstract class DBHelper
    {
        // admin account
        private static string ConnectionStringAdmin { get; }      
                = ConfigurationManager.ConnectionStrings["mariadb_admin"].ConnectionString;
        // should be ordinary user account (here both are admin)
        private static string ConnectionString { get; } 
                = ConfigurationManager.ConnectionStrings["mariadb"].ConnectionString;

        public static bool CheckDatabaseExistence()
        {
            int count = 0;
            try
            {
                // separate ConnectionString to access database as admin: information_schema
                using MySqlConnection connection = new MySqlConnection(ConnectionStringAdmin);
                connection.Open();

                string sql = "SELECT COUNT(SCHEMA_NAME) FROM information_schema.SCHEMATA WHERE SCHEMA_NAME = @dbName";
                using MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@dbName", MySqlDbType.VarChar).Value = "ChElements";

                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
            Debug.WriteLine($"DBHelper - Database found: {count}");
            return (count > 0);
        }

        public static bool CreateDatabase()
        {
            int count = -1;
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionStringAdmin);
                connection.Open();
                // # Datenbank erstellen
                string sqlCreateDB = "CREATE DATABASE chelements";
                // # Tabelle für Kontakte erstellen
                string sqlCreateTable = @"
                    CREATE TABLE zustand (
	                    Id INT AUTO_INCREMENT PRIMARY KEY,
	                    Name VARCHAR(20)
                    );

                    INSERT INTO zustand (Name)
                    VALUES ('Unbekannt'), ('Gas'), ('Feststoff'), ('Flüssigkeit');
                    
                    CREATE TABLE element(
                        Id INT AUTO_INCREMENT PRIMARY KEY, 
                        ZustandId INT(1),
                        Ordnungszahl INT(3), 
                        Name VARCHAR(50),
                        Symbol VARCHAR(2),
                        ChangedAt DATETIME,
                        CreatedAt DATETIME,
                        FOREIGN KEY (ZustandID) REFERENCES zustand(Id)
                    );";

                using MySqlCommand cmdCreateDb = new MySqlCommand(sqlCreateDB, connection);
                cmdCreateDb.ExecuteNonQuery();

                // switch to use newly created database
                connection.ChangeDatabase("chelements");
                using MySqlCommand cmdCreateTable = new MySqlCommand(sqlCreateTable, connection);
                count = cmdCreateTable.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
            
            Debug.WriteLine($"DBHelper - Tables created: {count +1}");
            return (count >= 0);
        }

        public static List<ChElement> GetAll()
        {
            List<ChElement> list = new();
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using Database db = new Database(connection);
                connection.Open();
                string sql = @"SELECT e.*, z.name AS ZustandName
                    FROM element e
                    JOIN zustand z ON e.ZustandId = z.Id
                    ORDER BY Ordnungszahl";

                //string sql = "ORDER BY ordnungszahl";
                list = db.Fetch<ChElement>(sql);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return list;
        }
        
        public static ChElement GetOne(int id)
        {
            ChElement? element = null;
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using Database db = new Database(connection);
                connection.Open();
                //element = db.SingleById<ChElement>(id);
                //string sql = "WHERE id = @0";
                string sql = @"
                    SELECT e.*, z.name AS ZustandName
                    FROM element e
                    JOIN zustand z ON e.ZustandId = z.Id
                    WHERE Id = @0";
                element = db.Single<ChElement>(sql, id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return element ?? new ChElement();      // ?? -> check if element is null
        }
        
        public static void AddOne(ChElement element)
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
        
        public static void UpdateOne(ChElement element)
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
        
        public static void DeleteOne(ChElement element)
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
