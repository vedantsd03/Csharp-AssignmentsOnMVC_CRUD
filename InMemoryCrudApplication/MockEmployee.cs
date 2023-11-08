using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_InMemory_CRUD
{
   
    internal class MockEmployee : IEmployee
    {
        private static List<Employee> emplist;
        public MockEmployee()
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
            Console.WriteLine("Adding Record");
            employee.Id = emplist.Max( r => r.Id)+1;
            emplist.Add(employee);  
            return employee;
        }

        public Employee Delete(int Id)
        {
            Console.WriteLine("Deleting Record");
            Employee employee = emplist.FirstOrDefault(e => e.Id == Id);
            emplist?.Remove(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return emplist;
        }

        public Employee GetEmployee(int Id)
        {
            Console.WriteLine("\n Fetched Record : ");
           return emplist.FirstOrDefault(e=>e.Id ==Id);
            
        }

        public Employee Update(Employee employeeChanges)
        {
            Console.WriteLine("Updating Record");
            Employee employee = emplist.FirstOrDefault(e => e.Id==employeeChanges.Id);
            if(employee != null) 
            {
                employee.Name = employeeChanges.Name;
                employee.Department = employeeChanges.Department;
                employee.Email = employeeChanges.Email;
            }
            return employee;
        }
    }
}
