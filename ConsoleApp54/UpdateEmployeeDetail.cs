using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class UpdateEmployeeDetail
    {
        public static void updateEmployee(List<Employee> employeeList)
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
                        foreach (var emp in employeeList)
                        {
                            if (emp.employee_Id == number)
                            {
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter the employee Name");
                                        string employeeName = Console.ReadLine();
                                        if (string.IsNullOrEmpty(employeeName) || employeeName.Any(char.IsDigit))
                                        {

                                            throw new Exception("please enter valid name");
                                        }
                                        else
                                        {
                                            emp.employee_Name = employeeName.ToLower();
                                            break;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }

                                }

                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter the employee Department");
                                        string employeeDepartment = Console.ReadLine();
                                        if (string.IsNullOrEmpty(employeeDepartment) || employeeDepartment.Any(char.IsDigit))
                                        {

                                            throw new Exception("please enter valid Department Name");
                                        }
                                        else
                                        {
                                            emp.employee_Department = employeeDepartment.ToLower();
                                            break;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }

                                }
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter the Employee technology");
                                        string employeeTechnology = Console.ReadLine();
                                        if (string.IsNullOrEmpty(employeeTechnology) || employeeTechnology.Any(char.IsDigit))
                                        {

                                            throw new Exception("please enter valid technology name");
                                        }
                                        else
                                        {
                                            emp.employee_Technology = employeeTechnology.ToLower();
                                            break;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }

                                }
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter the Employee Company Name");
                                        string employeeCompanyName = Console.ReadLine();
                                        if (string.IsNullOrEmpty(employeeCompanyName) || employeeCompanyName.Any(char.IsDigit))
                                        {

                                            throw new Exception("please enter valid technology name");
                                        }
                                        else
                                        {
                                            emp.employee_CompanyName = employeeCompanyName.ToLower();
                                            break;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }

                                }
                                employeeExist = true;
                                Console.WriteLine("Employee Record update successfully:");
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
