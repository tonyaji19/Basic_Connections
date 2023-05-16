using Basic_Connections.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Connections.Model
{
    public class profilings
    {
        public string employee_id { get; set; }
        public int education { get; set; }

        public List<profilings> GetProfilings()
        {
            var profiling = new List<profilings>();
            using SqlConnection connection = MyConnection.Get();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tb_tr_profilings";
                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var prof = new profilings();
                        prof.employee_id = reader.GetGuid(0).ToString();
                        prof.education = reader.GetInt32(1);

                        profiling.Add(prof);
                    }
                    return profiling;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return new List<profilings>();
        }

        public int InsertProfiling(profilings profilings)
        {
            int result = 0;
            using var connection = MyConnection.Get();
            connection.Open();
            var employee = new employees();
            var education = new Educations();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO tb_tr_profilings(employee_id, education_id) VALUES (@EmployeeId, @EducationId)";
                command.Transaction = transaction;

                var pEmpId = new SqlParameter();
                pEmpId.ParameterName = "@EmployeeId";
                pEmpId.Value = profilings.employee_id;
                command.Parameters.Add(pEmpId);

                var pEduId = new SqlParameter();
                pEduId.ParameterName = "@EducationId";
                pEduId.Value = profilings.education;
                command.Parameters.Add(pEduId);

                result = command.ExecuteNonQuery();
                transaction.Commit();

                return result;
            }

            catch (Exception e)
            {
                transaction.Rollback();
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}
