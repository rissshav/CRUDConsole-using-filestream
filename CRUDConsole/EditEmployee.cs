using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsole
{
    public class EditEmployee
    {
        List<Employee> editEmployee = new List<Employee>();

        public EditEmployee(List<Employee> editEmployee)
        {
            this.editEmployee = editEmployee;
        }
        public List<Employee> getEditEmployee()
        {
            //To Print the list of employee 
            ViewEmployee print = new ViewEmployee(editEmployee);
            print.ViewAllEmployee();
            bool loopflag = true;
            while (loopflag)
            {
                Console.WriteLine("\nEnter the ID of the Employee");
                int inputID;
                if (int.TryParse(Console.ReadLine(), out inputID))
                {
                    bool idflag = true;
                    foreach (Employee emp in editEmployee)
                    {
                        if (emp.id == inputID)
                        {
                            loopflag = false;
                            idflag = false;
                            Console.WriteLine("Updating the details of ID " + emp.id + "\n");
                            //For updation of Name
                            Console.WriteLine("Enter the updated name");
                            Validation validate = new Validation();
                            emp.name = Console.ReadLine();
                            emp.name = validate.checkName(emp.name);
                            //For updation of Age
                            Console.WriteLine("\nUpdate the age\nPlease enter your date of birth (YYYY-MM-DD):");
                            bool ageloopflag = true;
                            while (ageloopflag)
                            {
                                emp.age = AddEmployee.CalculateAge();
                                if (emp.age >= 18)
                                {
                                    ageloopflag = false;
                                }
                            }
                            //For updation of Department
                            Console.WriteLine("\nUpdate the Department");
                            bool deptflag = true;
                            while (deptflag)
                            {
                                emp.department = AddEmployee.department();
                                if (emp.department != "")
                                {
                                    deptflag = false;
                                }
                            }
                            //For updation of Hobbies
                            Console.WriteLine("\nUpdate the Hobbies");
                            bool hobbflag = true;
                            while (hobbflag)
                            {
                                emp.hobbies = AddEmployee.Hobbies();
                                if (emp.hobbies != "")
                                {
                                    hobbflag = false;
                                }
                            }
                            //For updation of Salary
                            Console.WriteLine("\nUpdate Salary");
                            bool salaryflag = true;
                            while (salaryflag)
                            {
                                if (double.TryParse(Console.ReadLine(), out emp.salary))
                                {
                                    salaryflag = false;
                                }
                                else
                                {
                                    Console.WriteLine("Please Enter the Valid Amount");
                                }
                            }
                        }

                    }
                    if (idflag == true)
                    {
                        Console.WriteLine("\nEmployee Not Found!");
                        Console.WriteLine("Try Again!!\n");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a Integer only.\n");
                }

            }
            Console.WriteLine("Updated Successfully\n");
            return this.editEmployee;
        }
    }
}
