using System;

namespace CSharpBasics_T026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            try
            {
                employees.SetEmployeeID(-5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                employees.SetEmployeeID(55);
                employees.SetFName(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                employees.SetFName("Shiva");
                employees.SetLName("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            employees.SetLName("Jagdish");

            Console.WriteLine(employees.GetFName());
            Console.WriteLine(employees.GetLName());
            Console.WriteLine(employees.GetEmployeeID());
        }
    }

    public class Employees
    {
        // Encapsulate the the class means control the behavior of the fields based on the requirement.
        private int employeeID;
        private string fName;
        private string lName;


        public void SetEmployeeID(int id)
        {
            if (id < 0)
                throw new Exception("Exception: ID Can't Be Negative");
            else
                employeeID = id;
        }

        public int GetEmployeeID()
        {
            return employeeID;
        }

        public void SetFName(string fstName)
        {
            if (!string.IsNullOrEmpty(fstName))
                fName = fstName;
            else
                throw new Exception("Exception: First Name Can't be null or empty.");
        }

        public string GetFName()
        {
            return string.IsNullOrEmpty(fName) ? "No Fname." : fName;
        }

        public void SetLName(string lstName)
        {
            if (!string.IsNullOrEmpty(lstName))
                lName = lstName;
            else
                throw new Exception("Exception: Last Name Can't be null or empty.");
        }

        public string GetLName()
        {
            return string.IsNullOrEmpty(lName) ? "No Lname." : lName;
        }
    }
}
