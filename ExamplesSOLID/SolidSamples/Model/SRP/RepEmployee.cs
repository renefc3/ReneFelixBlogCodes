using System.Data.SqlClient;

namespace Model.SRP
{
    /// <summary>
    /// The responsibility of this class is persist the employee into the database
    /// REPONSABILITY: PERSIST EMPLOYEE(DON'T HAVE ANY BUSINESS LOGIC)
    /// </summary>
    public class RepEmployee
    {
        private SqlConnection _connection;

        public RepEmployee()
        {


        }

        public void Save(Employee employee)
        {
            using (_connection = new SqlConnection())
            {
                _connection.Open();
                SqlCommand cmd = _connection.CreateCommand();
                if (employee.Id <= 0)//Insert
                {
                    cmd.CommandText = "INSERT INTO EMPLOYEE (DE_NAME, NU_AGE, NU_HOURLY_PAY) VALUES (@NAME, @AGE, @HOURLY_PAY); SELECT @@IDENTITY;";

                    cmd.Parameters.Add(new SqlParameter("@NAME", employee.Name));
                    cmd.Parameters.Add(new SqlParameter("@AGE", employee.Age));
                    cmd.Parameters.Add(new SqlParameter("@HOURLY_PAY", employee.HourlyPay));
                    int idEmployee = (int) cmd.ExecuteScalar();
                    employee.Id = idEmployee;
                }
                else //Update
                {
                    cmd.CommandText = "UPDATE EMPLOYEE set DE_NAME = @NAME, NU_AGE= @AGE, NU_HOURLY_PAY = @HOURLY_PAY  WHERE id = @ID";

                    cmd.Parameters.Add(new SqlParameter("@NAME", employee.Name));
                    cmd.Parameters.Add(new SqlParameter("@AGE", employee.Age));
                    cmd.Parameters.Add(new SqlParameter("@HOURLY_PAY", employee.HourlyPay));
                    cmd.Parameters.Add(new SqlParameter("@ID", employee.Id));
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}