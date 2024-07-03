using System;

namespace CSharpBasics_T028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            try
            {
                employees.EmployeeID = -5;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                employees.EmployeeID = 55;
                employees.FName = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                employees.FName = "Shiva";
                employees.LName = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            employees.LName = "Jagdish";

            Console.WriteLine(employees.FName);
            Console.WriteLine(employees.LName);
            Console.WriteLine(employees.EmployeeID);
            Console.WriteLine(employees.FullName);

            Employees employees2 = new Employees()
            {
                EmployeeID = 5,
                EmailId = "ABCD@gmail.com",
                FName = "ABC",
                LName = "ZXY",
            };
            Console.WriteLine(employees2.FullName);
        }
    }

    public struct Employees
    {
        private int employeeID;
        private string fName;
        private string lName;
        private string emailId;

        public string EmailId { get; set; }

        public int EmployeeID
        {
            get { return employeeID; }
            set
            {
                if (value < 0)
                    throw new Exception("Exception: ID Can't Be Negative");
                else
                    employeeID = value;
            }
        }

        public string FName
        {
            get { return string.IsNullOrEmpty(fName) ? "No Fname." : fName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    fName = value;
                else
                    throw new Exception("Exception: First Name Can't be null or empty.");
            }
        }

        public string LName
        {
            get { return string.IsNullOrEmpty(lName) ? "No Lname." : lName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    lName = value;
                else
                    throw new Exception("Exception: Last Name Can't be null or empty.");
            }
        }

        public string FullName
        {
            get
            {
                return FName + " " + LName;
            }
        }
    }
}
