using System.Data.SqlClient;

namespace Model.SRP
{
    /// <summary>
    /// This class has to responsability one persist the class and other the business logic inside
    /// </summary>
    public class EmployeeWithoutSRP
    {
        private int _id;
        private string _name;
        private int _age;
        private int _hourlyPay;
        private SqlConnection _connection;


        public EmployeeWithoutSRP()
        {

        }
        public EmployeeWithoutSRP(string name, int age, int hourlyPay)
        {
            Name = name;
            Age = age;
            HourlyPay = hourlyPay;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Nome do Empregado
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Idade
        /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// Valor hora
        /// </summary>
        public int HourlyPay
        {
            get { return _hourlyPay; }
            set { _hourlyPay = value; }
        }


        /// <summary>
        /// Regra de negocio
        /// </summary>
        /// <returns></returns>
        public int CalculatePayment(int hoursWorkedInMonth)
        {
            return HourlyPay * hoursWorkedInMonth;
        }

        public void Save()
        {
            using (_connection = new SqlConnection())
            {
                _connection.Open();
                SqlCommand cmd = _connection.CreateCommand();
                if (Id <= 0)//Insert
                {
                    cmd.CommandText = "INSERT INTO EMPLOYEE (DE_NAME, NU_AGE, NU_HOURLY_PAY) VALUES (@NAME, @AGE, @HOURLY_PAY); SELECT @@IDENTITY;";

                    cmd.Parameters.Add(new SqlParameter("@NAME", Name));
                    cmd.Parameters.Add(new SqlParameter("@AGE", Age));
                    cmd.Parameters.Add(new SqlParameter("@HOURLY_PAY", HourlyPay));
                    int idEmployee = (int)cmd.ExecuteScalar();
                    Id = idEmployee;
                }
                else //Update
                {
                    cmd.CommandText = "UPDATE EMPLOYEE set DE_NAME = @NAME, NU_AGE= @AGE, NU_HOURLY_PAY = @HOURLY_PAY  WHERE id = @ID";

                    cmd.Parameters.Add(new SqlParameter("@NAME", Name));
                    cmd.Parameters.Add(new SqlParameter("@AGE", Age));
                    cmd.Parameters.Add(new SqlParameter("@HOURLY_PAY", HourlyPay));
                    cmd.Parameters.Add(new SqlParameter("@ID", Id));
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}