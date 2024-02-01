using BeautySalon.DAL.DTO;
using BeautySalon.DAL.StoredProcedures;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BeautySalon.DAL.Repositories
{
    public class TypesRepository
    {
        public List<TypesDTO> GetServiceType()
        {
            using (IDbConnection connection = new SqlConnection(Options.ConnectionString))
            {
                return connection.Query<TypesDTO>(Procedures.GetAllEmployeesProcedure).ToList();
            }
        }
        public List<TypesDTO> GetFiveElementsFromType() 
        {
            using (IDbConnection connection = new SqlConnection(Options.ConnectionString))
            {
                // Выполнение запроса и получение результата
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Перебор и вывод результатов
                    while (reader.Read())
                    {
                        int typeId = (int)reader["Id"];
                        string title = (string)reader["Title"];
                        bool isDeleted = (bool)reader["IsDeleted"];

                        Console.WriteLine($"TypeId: {typeId}, Title: {title}, IsDeleted: {isDeleted}");
                    }
                }
            }
        }
    }
}

