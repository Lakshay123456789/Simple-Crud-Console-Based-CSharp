using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class ShowEmployeeCompanyName
    {
        public static void ShowCompanyName(List<Employee> employeeList)
        {
            var QueryGroup = from emp in employeeList
                             group emp by emp.employee_CompanyName into NewCompanyGroup
                             orderby NewCompanyGroup.Key
                             select NewCompanyGroup;
            foreach(var company in QueryGroup)
            {
                Console.WriteLine("\t\t\t------------------------------------------------------------------------");
                Console.WriteLine("Company Name :- {0}",company.Key);
                Console.WriteLine("\tId\t\tName\t\tDepartment\t\tTechnology\t\tCompany_Name");
                foreach (var employee in company)
                {
                    Console.WriteLine($"{employee.employee_Id}\t\t{employee.employee_Name}\t\t{employee.employee_Department}\t\t\t{employee.employee_Technology}\t\t\t{employee.employee_CompanyName}");
                }
                Console.WriteLine("\t\t\t------------------------------------------------------------------------");

            }
        }
    }
}
