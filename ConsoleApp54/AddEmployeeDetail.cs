using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
   class AddEmployeeDetail
    {
        public static void AddNewEmployee(List<Employee> employeelist)
        {
            Employee employee = new Employee();
           
            int employeeId = 0;
            if (employeelist != null)
            {
                foreach (Employee emp in employeelist)
                {
                    if (emp.employee_Id > employeeId)
                    {
                        employeeId = emp.employee_Id;
                    }
                }
            }
            employeeId += 1;
            employee.employee_Id = employeeId;
            



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
                        employee.employee_Name = employeeName.ToLower();
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
                        employee.employee_Department = employeeDepartment.ToLower();
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
                        employee.employee_Technology = employeeTechnology.ToLower();
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
                        employee.employee_CompanyName = employeeCompanyName.ToLower();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }


          

            employeelist.Add(employee);
            Console.WriteLine("employee record add successfully");



        }
    }
}
