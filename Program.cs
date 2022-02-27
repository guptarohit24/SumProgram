using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publicmethod

{
    class myclass1
    {
        public string name;
        public int age;
        public int id;
        public string school;
        public void getdetail(string name, int age ,int  id ,string school)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.school = school;
            
            Console.WriteLine("name = {0}  age = {1}  id = {2}  school = {3}",this.name,this.age ,this.id,this.school);
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
              myclass1 obj1 = new myclass1();
           
            Console.WriteLine("enter the  name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the school id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the school nmae");
            string school = Console.ReadLine();
            Console.WriteLine(name, age, id, school);
            

            obj1.getdetail("rohit",21,212,"pms");
            Console.ReadLine();

        }
    }
}
