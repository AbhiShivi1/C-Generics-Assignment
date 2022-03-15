using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Employee
    { 
        private static string Id;
        private static string Name;
        private static string DepartmentName;


       // public delegate string MethodCalled(Object sender, EventArgs args);

       public Employee(string Id,string Name,string DepartmentName)
        {
            Employee.Id = Id;
            Employee.Name = Name;
            Employee.DepartmentName = DepartmentName;

        }
        public  string GetId()
        {
            return Id;
           
        }
        public string GetName()
        {
            return Name;
        }
        public string GetDepartmentName()
        {
            return DepartmentName;
        }

        public string GetId(String id)
        {
            Id = id;
            return Id;
        }
        public string GetName(String name)
        {
            Name = name;
            return Name;
        }
        public string GetDepartmentName(String departmentname)
        {
            DepartmentName = departmentname;
            return DepartmentName;
        }


        public static void UserInput()
        {
            Console.WriteLine("Enter Id");
            Id = Console.ReadLine();
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter DepartmentName");
            DepartmentName = Console.ReadLine();

        }

       // public event MethodCalled methodused;
        static void Main(string[] args)
        { 
            
             UserInput();
        Employee obj = new Employee(Id,Name,DepartmentName);
           
            Console.WriteLine(obj.GetId());
            Console.WriteLine(obj.GetName());
            Console.WriteLine(obj.GetDepartmentName());
            Console.ReadLine();
           


        }
    }
}
