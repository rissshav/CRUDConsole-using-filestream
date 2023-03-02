using CRUDConsole;

internal class Program
{
    private static void Main(string[] args)
    {
        // Generic list has been created for Employee class
        List<Employee> employees = new List<Employee>();

        //some added Employee
        Employee obj = new Employee(1, "Ishan", 21 , "IT", "Music", 12000.00);
        Employee obj1 = new Employee(2, "Rishav", 21, "IT", "Music", 12000.00);
        employees.Add(obj);
        employees.Add(obj1);

        // Main Menu
        bool loopflag = true;
        while (loopflag)
        {
            Console.WriteLine("Employee Management\n");
            Console.WriteLine("Please Select the below options");
            Console.WriteLine("1. View Employee");
            Console.WriteLine("2. Add Employee");
            Console.WriteLine("3. Edit Employee");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Save data to local device");
            Console.WriteLine("6. Exit");
            string input = Console.ReadLine();
            //Using switch to meet multiple cases above
            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("View Employee\n");
                    ViewEmployee view = new ViewEmployee(employees);
                    view.ViewAllEmployee();
                    Console.WriteLine("\nPress Enter to go to Main Menu");
                    Console.ReadLine();
                    Console.Clear();
                    break; 
                case "2":
                    Console.Clear();
                    Console.WriteLine("Add Employee\n");
                    AddEmployee add = new AddEmployee();
                    employees.Add(add.AddEmployeeToList());
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Edit Employee\n");
                    EditEmployee edit = new EditEmployee(employees);
                    edit.getEditEmployee();
                    Console.WriteLine("\nPress Enter to go to Main Menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Delete Employee\n");
                    DeleteEmployee delete = new DeleteEmployee(employees);
                    delete.DeleteEmp();
                    Console.WriteLine("Press Enter to go to Main Menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Save to Local device\n");
                    Save save = new Save(employees);
                    save.getSave();
                    Console.WriteLine("Press Enter to go to Main Menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "6":
                    Console.WriteLine("Exiting");
                    loopflag= false;
                    break;
                    default: Console.WriteLine("Please Select the valid option\n");
                    break;
            }
        }

    }
}