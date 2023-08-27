using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class ShowByEmployeeId
    {
        public static void ShowEmployee_Id(List<Employee> employeeList)

        {
            while (true)
            {
                try
                {
                    bool employeeExist = false;
                    Console.WriteLine("Please enter Employee Id:");
                    int EmployeeId = int.Parse(Console.ReadLine());
                    foreach(Employee emp in employeeList)
                    {
                        if(emp.employee_Id == EmployeeId)
                        {
                            Console.WriteLine("\t\t\t--------- Employee Detail-------\n");
                            Console.WriteLine("\t\tId\t\tName\t\tDepartment\t\tTechnology\t\tCompany_Name");
                            Console.WriteLine($"\t\t{emp.employee_Id}\t\t{emp.employee_Name}\t\t{emp.employee_Department}\t\t\t{emp.employee_Technology}\t\t\t{emp.employee_CompanyName}");
                            Console.WriteLine("\t\t\t-------------------------------------------------------------------------");
                            employeeExist = true;
                            break;
                        }
                    }
                    if(employeeExist )
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This Employee Id does not Exist");
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter an valid Employee Id.");
                }
            }

        }
    }
}
