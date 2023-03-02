using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsole
{
    public class DeleteEmployee
    {
        List<Employee> delemp = new List<Employee>();
        
        public DeleteEmployee(List<Employee> delemp)
        {
            this.delemp = delemp;
        }

        public List<Employee> DeleteEmp()
        {
            //To check either the list of employee is empty or not
            if (delemp.Count == 0)
            {
                Console.WriteLine("\nThe list is already empty\n");
                return delemp;
            }
            bool loopflag = true;
            while (loopflag)
            {
                //To Print the List of Employee
                ViewEmployee print = new ViewEmployee(delemp);
                print.ViewAllEmployee();
                Console.WriteLine("\nEnter the ID of the Employee");
                int inputID;
                if (int.TryParse(Console.ReadLine(), out inputID))
                {
                    bool idflag = true;
                    foreach (Employee item in delemp)
                    {
                        if (item.id == inputID)
                        {
                            idflag = false;
                            loopflag = false;
                            delemp.RemoveAt(inputID - 1);
                            Console.WriteLine("\nEmployee Deleted");
                            break;
                        }
                    }
                    if (idflag == true)
                    {
                        Console.WriteLine("\nEmployee not found");
                        Console.WriteLine("Try agian\n");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a Integer only.\n");
                }
            }
            return delemp;
        }
    }
}
