using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class DeleteEmployeeDetail
    {
        public static void DeleteEmployee(List<Employee> employeeList)
        {
            if (employeeList != null)
            {

                while (true)
                {
                    Console.WriteLine("Please enter Employee Id:");
                    string userInput = Console.ReadLine();
                    int number;

                    if (int.TryParse(userInput, out number))
                    {
                        bool employeeExist = false;
                      foreach(var emp in employeeList)
                        {
                            if (emp.employee_Id == number)
                            {
                                employeeList.Remove(emp);
                                employeeExist= true;
                                Console.WriteLine("Employee Record delete successfully:");
                                break;
                            }
                        }
                        if (employeeExist)
                        {
                            break;
                        }
                        Console.WriteLine("This Employee Id does not Exist");

                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an valid Employee Id.");
                    }
                }
            }
            else
            {
                Console.WriteLine("list is empty");
            }
        }

    }
}
