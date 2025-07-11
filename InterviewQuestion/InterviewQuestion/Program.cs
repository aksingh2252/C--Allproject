using System;
namespace Structure
{
    public class Employee
    {
        public string empId { get; set; }

        public string empName { get; set; }
        public string empDesignation { get; set; }

        public string mangerEmpId { get; set; }
    }
    class Main()
    {

        List<Employee> emp = new List<Employee>
            {
                 new Employee { empId = "X7F3", empName = "john Doe", empDesignation = "CEO", mangerEmpId = "Null" },
                 new Employee{empId="POR4", empName = "jane smith", empDesignation="CTO",mangerEmpId="X7E#"}

            };



    }
}


