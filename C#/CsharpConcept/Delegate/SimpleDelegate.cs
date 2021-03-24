using System;
using System.Collections.Generic;
using System.Text;
using UseOfDelegate;

namespace Delegate
{
    public delegate void SomeMethod(string message); //Delegate Declaration
    class SimpleDelegate
    {
        static void PrintName(string name)
        {
            Console.WriteLine("Name {0}", name);
        }
        static void Main(string[] args)
        {
            SomeMethod method = new SomeMethod(PrintName); //Set up a target method
            method("Jyotiraditya Dhalmahapatra");

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { EmpId= 1, EmpName="John", Salary=7000, Experience=7});
            empList.Add(new Employee() { EmpId= 2, EmpName = "Mary", Salary = 6500, Experience = 6 });
            empList.Add(new Employee() { EmpId= 3, EmpName = "Joseph", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { EmpId= 4, EmpName = "Xavier", Salary = 3000, Experience = 3 });
            empList.Add(new Employee() { EmpId = 4, EmpName = "Lata", Salary = 8000, Experience = 8 });
            //Employee.promoteEmployee(empList);

            IsPromotable isEligibleToPromote = new IsPromotable(EmployeeEligibleForPromotion);
            Employee.promoteEmployee(empList, isEligibleToPromote);
        }
        static bool EmployeeEligibleForPromotion(Employee emp)
        {
            if(emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
namespace UseOfDelegate
{
    public delegate bool IsPromotable(Employee emp);
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

       public static void promoteEmployee(List<Employee> empList, IsPromotable isElegibleToPromote)
        {
            foreach(Employee emp in empList)
            {
                if(isElegibleToPromote(emp))
                {
                    Console.WriteLine("Employee {0} Promoted", emp.EmpName);
                }
            }
        }

    }
}
