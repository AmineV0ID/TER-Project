using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Dapper;

namespace EMR.Domain
{
    public class SqliteDataAccess
    {
        public static List<Patient> GetPatients()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Patient>("select * from Patient", new DynamicParameters());
                return output.ToList();
            }
        }   
        
        public static Patient GetPatientById(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Get<Patient>(id);
            }
        }

        public static List<Patient> GetPatientsByName(string name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                
                    var query =
                        "SELECT [Id], [FirstName], [LastName], [Age], [PhoneNumber], [Address], [Gender], [Height], [Weight] , [FullName] " +
                        "FROM[Patient]" +
                        $"WHERE[FullName] LIKE '%{name}%';";
                    var output = cnn.Query<Patient>(query, new DynamicParameters());
                    return output.ToList();
            }
        }
        public static void DeletePatient(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Delete<Patient>(id);
            }
        }

        public static void SavePatient(Patient patient)
        {
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLite);
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                var identity = SimpleCRUD.Insert(connection, patient);
            }
        }
        public static void EditPatient(Patient patient)
        {
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLite);
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                var identity = SimpleCRUD.Update(connection,patient);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
