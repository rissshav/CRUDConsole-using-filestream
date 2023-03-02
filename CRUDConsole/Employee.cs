using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsole
{
    public class Employee
    {
        public int id;
        public string name;
        public int age;
        public string department;
        public string hobbies;
        public double salary;

        public Employee(int id, string name, int age, string department, string hobbies, double salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.department = department;
            this.hobbies = hobbies;
            this.salary = salary;
        }
    }
}
