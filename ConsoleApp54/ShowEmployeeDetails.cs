using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
   class ShowEmployeeDetails
    {
        public static void ShowEmployee(List<Employee> employeelist)
        {
            Console.WriteLine("\t\t\t---------show all Employee Details-------\n");
            Console.WriteLine("\t\tId\t\tName\t\tDepartment\t\tTechnology\t\tCompany_Name");
            foreach(var employee in employeelist)
            {
                Console.WriteLine($"\t\t{employee.employee_Id}\t\t{employee.employee_Name}\t\t{employee.employee_Department}\t\t\t{employee.employee_Technology}\t\t\t{employee.employee_CompanyName}");
            }
            Console.WriteLine("\t\t\t------------------------------------------------------------------------");
        } 
    }
}
