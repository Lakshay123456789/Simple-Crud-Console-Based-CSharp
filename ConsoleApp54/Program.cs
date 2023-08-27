using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    employee_Id = 1,
                    employee_Name = "abc",
                    employee_Department = "Hr",
                    employee_CompanyName = "aspirefox",
                    employee_Technology = "C#"
                },
                  new Employee()
                  {
                      employee_Id = 2,
                      employee_Name = "cde",
                      employee_Department = "IT",
                      employee_CompanyName = "aspirefox",
                      employee_Technology = "Java"
                  },
                    new Employee()
                    {
                        employee_Id = 3,
                        employee_Name = "fgh",
                        employee_Department = "IT",
                        employee_CompanyName = "ert",
                        employee_Technology = "C++"
                    },
                      new Employee()
                      {
                          employee_Id = 5,
                          employee_Name = "abce",
                          employee_Department = "CSE",
                          employee_CompanyName = "qwes",
                          employee_Technology = "Python"
                      }
            };

            while (true)
            {
              
                bool exist = false;
                Console.WriteLine("Enter the any Choice");
                Console.WriteLine("1.Show employee details ");
                Console.WriteLine("2.Add the new employee detail");
                Console.WriteLine("3.Update employee detail");
                Console.WriteLine("4.Delete employee detail");
                Console.WriteLine("5.Show Employee By Compnay");
                Console.WriteLine("6.Show Company by Employee Id");
                Console.WriteLine("7.exit");
                try
                {
                    int keys = int.Parse(Console.ReadLine());
                    
                    switch (keys)
                    {
                        case 1:
                        //    Console.Clear();
                            ShowEmployeeDetails.ShowEmployee(employees);
                            break;
                        case 2:
                          //  Console.Clear();
                            AddEmployeeDetail.AddNewEmployee(employees);
                            break;
                        case 3:
                            UpdateEmployeeDetail.updateEmployee(employees);
                            break;
                        case 4:
                            DeleteEmployeeDetail.DeleteEmployee(employees);
                            break;
                        case 5:
                            ShowEmployeeCompanyName.ShowCompanyName(employees);
                            break;
                        case 6:
                            ShowByEmployeeId.ShowEmployee_Id(employees);
                            break;
                        case 7:
                            exist = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;


                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
                if (exist)
                {
                    break;
                }
               
            }
           
        }
    }
}
