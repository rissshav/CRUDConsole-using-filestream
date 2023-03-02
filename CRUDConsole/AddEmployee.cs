using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsole
{
    public class AddEmployee
    {
        public static int CalculateAge()
        {
            // Prompt the user to enter their DOB in YYYY-MM-DD format
            string dobStr = Console.ReadLine();
            int age = 0;
            // Convert the user's input into a DateTime object
            DateTime dob;
            if (DateTime.TryParse(dobStr, out dob))
            {
                // Calculate the user's age based on their DOB
                age = DateTime.Now.Year - dob.Year;
                if (DateTime.Now.Month < dob.Month || (DateTime.Now.Month == dob.Month && DateTime.Now.Day < dob.Day))
                {
                    age--;
                }
                // Output the user's age
                Console.WriteLine("Your age is: " + age+ "\n");
                
            }
            else
            {
                Console.WriteLine("Invalid date of birth format or age is less than 18\nPlease Enter again");
            }
            return age;
        }
        public static string department()
        {
            Console.WriteLine("Select your department");
            Console.WriteLine("1. HR\n2. Manager\n3. Development\n4. Team Lead");
            string x = Console.ReadLine();
            string select = "";
            switch (x)
            {
                case "1":
                    Console.WriteLine("You have selected HR");
                    select = "HR";
                    return select;
                case "2":
                    Console.WriteLine("You have selected Manager");
                    select = "Manager";
                    return select;
                case "3":
                    Console.WriteLine("You have selected Development");
                    select = "Development";
                    return select;
                case "4":
                    Console.WriteLine("You have selected Team lead");
                    select = "Team Lead";
                    return select;
                default:
                    Console.WriteLine("Please Select valid option");
                    break;
            }

            return select;

        }
        public static string Hobbies()
        {
            Console.WriteLine("\nSelect your Hobbies");
            Console.WriteLine("1. Music\n2. Playing\n3. Other");
            string x = Console.ReadLine();
            string select = "";
            switch (x)
            {
                case "1":
                    Console.WriteLine("You have selected Music");
                    select = "Music";
                    return select;
                case "2":
                    Console.WriteLine("You have selected Playing");
                    select = "Playing";
                    return select;
                case "3":
                    Console.WriteLine("You have selected Other");
                    select = "Other";
                    return select;
                default:
                    Console.WriteLine("Please select valid option");
                    break;
            }
            return select;
        }

        List<Employee> add =new List<Employee>();
        public int id = 2;
        public Employee AddEmployeeToList()
        {
            //creating object of validation class
            Validation validate= new Validation();

            Console.WriteLine("Enter the name of employee");
            string name = Console.ReadLine();
            name = validate.checkName(name);

            Console.WriteLine("Please enter your date of birth (YYYY-MM-DD):");
            bool ageloopflag = true;
            int age = 0;
            while (ageloopflag)
            {
                age = AddEmployee.CalculateAge();
                if(age >= 18)
                {
                    ageloopflag= false;
                }
            }

            Console.WriteLine("Department");
            bool deptflag = true;
            string dept = "";
            while (deptflag)
            {
                dept = AddEmployee.department();
                if (dept != "")
                {
                    deptflag = false;
                }
            }

            Console.WriteLine("Hobbies");
            bool hobbflag = true;
            string hobb = "";
            while (hobbflag)
            {
                hobb = AddEmployee.Hobbies();
                if(hobb != "")
                {
                    hobbflag = false;
                }
            }

            Console.WriteLine("\nEnter Your Salary");
            bool salaryflag = true;
            double salary = 0;
            while (salaryflag)
            {
                if(double.TryParse(Console.ReadLine(), out salary))
                {
                    salaryflag = false;
                }
                else
                {
                    Console.WriteLine("Please Enter the Valid Amount");
                }
            }
            Console.WriteLine("Employee Added Successfully\n");
            id += 1;
            Console.WriteLine("Press Enter to go to Main Menu");
            Console.ReadLine();
            Console.Clear();
            Employee emp = new Employee(id, name, age, dept, hobb, salary);
            return emp;
        }
    }
}
