using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2_C_ADV
{
    internal class EmployeeComparerName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;

            return X.Name.CompareTo(Y.Name);
        }
    }
    internal class Employee : IComparable
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public int Age { get; set; }


        public int Salary { get; set; }

        public int CompareTo(object? obj)
        {
            Employee E = (Employee)obj;

            return this.Age.CompareTo(E.Age);
        }

        public override string ToString()
        {
            return $"Id: {Id} , Name:{Name} , Age:{Age} , Salary:{Salary}";
        }
    }
}
