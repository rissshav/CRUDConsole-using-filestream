using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsole
{
    public class Save
    {
        List<Employee> save = new List<Employee>();

        public Save(List<Employee> save)
        {
            this.save = save;
        }
        public void getSave()
        {
            string path = @"D:\employeelist.txt";
            using(FileStream fs = new FileStream(path,FileMode.Create))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Employee item in save)
                    {
                        sw.WriteLine("{0} {1} {2} {3} {4} {5}", item.id, item.name, item.age, item.department, item.hobbies, item.salary);
                    }
                }
            }
            Console.WriteLine("Data Saved to {0}",path);
        }
    }
}
