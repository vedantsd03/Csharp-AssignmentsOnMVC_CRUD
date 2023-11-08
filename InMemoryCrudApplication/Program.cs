namespace CA_InMemory_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MockEmployee db = new MockEmployee();
            Disp(db);

            Employee emp  = new Employee { Name = "Kavita" , Department = Dept.HR ,Email="kavita12@gamil.com"};
            db.Add(emp);
            Disp(db);

           Employee Empget= db.GetEmployee(5);
            Console.WriteLine(Empget);

            Employee empupdate = new Employee {Id=5, Name ="shantanu", Department = Dept.HR, Email="shanatanuthakre12@gmail.com" };
            db.Update(empupdate);
            Disp(db);

            db.Delete(5);
            Disp(db);
            
        }
        static void Disp(MockEmployee mockemployee)
        {
           foreach(Employee e in mockemployee.GetAllEmployee())
                Console.WriteLine(e);
            Console.WriteLine();
        }   
    }
}