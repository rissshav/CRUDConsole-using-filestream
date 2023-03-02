using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CRUDConsole
{
    public class Validation
    {
        public string checkName(string name)
        {
            string regex = @"^[a-zA-Z]+[a-zA-Z\s]+$";
            Regex re = new Regex(regex);
            if (re.IsMatch(name))
            {
                return name;
            }
            string fname = "";
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Correct Name: ");
                string tempName = Console.ReadLine();
                if (re.IsMatch(tempName))
                {
                    fname = tempName;
                    flag = false;
                }
            }
            return fname;
        }
    }
}
