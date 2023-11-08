using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_InMemory_CRUD
{
    internal interface IEmployee
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();
        Employee Add(Employee employee);
        Employee Update(Employee employeeChanges);
        Employee Delete(int Id);
    }
    /*
    class MEmployee : IEmployee
    {
        private static IList<Employee> emplist;
        public MEmployee()
        {
            emplist = new List<Employee>(){
                new Employee{ Id=1, Name="Kunal",Department=Dept.MKT , Email = "kunaldhanawade12@gmail.com"},
                new Employee{ Id=2, Name="omkar",Department=Dept.HR , Email = "omkarsakpal@gmail.com"},
                new Employee{ Id=3, Name="sanket",Department=Dept.ADV , Email = "sanketmore123@gmail.com"},
                new Employee{ Id=4, Name="shubham",Department=Dept.MKT , Email = "shubhamsabhu77200@gmail.com"},
            };
        }
        public Employee Add(Employee employee)
        {
            employee.Id=emplist.Max(emp => emp.Id);
            emplist.Add(employee);
            return employee;
        }

        public Employee Delete(int Id)
        {
           Employee emp = emplist.FirstOrDefault(emp => emp.Id==Id);
            if (emp != null)
            {
                emplist.Remove(emp);
            }
            return emp;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return emplist;
        }

        public Employee GetEmployee(int Id)
        {
            Employee emp = emplist.FirstOrDefault(emp => emp.Id==Id);
            return emp;
        }
        public Employee Update(Employee employeeChanges)
        {
            Employee emp =emplist.FirstOrDefault(emp =>emp.Id==employeeChanges.Id);
            if (emp != null)
            {
                emp.Name = employeeChanges.Name;
                emp.Department = employeeChanges.Department;
                emp.Email = employeeChanges.Email;
            }
            return emp;

            
        }
        
        public void Display(MEmployee emp)
        {
    var a=emp.GetAllEmployee()
            foreach (Employee employee in a )
            {
                Console.WriteLine(employee);
            }
        }
    }
        */

}
