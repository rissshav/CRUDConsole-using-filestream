using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsole
{
    public class ViewEmployee
    {
        List<Employee> view = new List<Employee>();

        public ViewEmployee(List<Employee> view)
        {
            this.view = view;
        }
        public void ViewAllEmployee()
        {
            foreach (Employee item in view)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}",item.id, item.name, item.age, item.department, item.hobbies, item.salary);
            }

        }
    }
}
