using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SRP
{
    /// <summary>
    /// The responsibility of this class is manage the employee property, without persist anything. 
    /// The algorithm to calculate the payment is part of that responsability
    /// REPONSABILITY: MANAGE EMPLOYEE(NOT PERSIST)
    /// </summary>
    public class Employee
    {
        private int _id;
        private string _name;
        private int _age;
        private int _hourlyPay;

        public Employee()
        {

        }
        public Employee(string name, int age, int hourlyPay)
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
    }
}
