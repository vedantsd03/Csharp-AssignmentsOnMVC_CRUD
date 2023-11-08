using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_InMemory_CRUD
{
    
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dept Department { get; set; }
        public string Email {  get; set; }

        public override string ToString()
        {
            return string.Format($"ID  : {Id}  \t Name : {Name}   \t Department : {Department} \t Email : {Email}");
        }
    }
    public enum Dept { MKT, ADV, HR }
}
