using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genric_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<employee> Emplist = new List<employee>();
            employee emp1 = new employee()
            {
                name = "rohit",
                age = 21,
              designation = "manager"
     
            };
            employee emp2 = new employee()
            {
                name = "shivam",
                age = 22,
                designation = " chief manager"
            };
            employee emp3 = new employee()
            {
                name = "shivam",
                age = 22,
                designation = "owner"
            };
          
            Emplist.Add(emp1);
            Emplist.Add(emp2);
            Emplist.Add(emp3);
            foreach (employee emp in Emplist)
            {
                Console.WriteLine("employee name is : {0}  age : {1}  dwsignation : {2}",emp.name,emp.age,emp.designation);
            }
            List<int> mynumber = new List<int>();
            mynumber.Add(12);
            mynumber.Add(13);
            mynumber.Add(114);
            mynumber.Add(15);
            List<string> name = new List<string>();
            name.Add("rohit");
            name.Add("anjali");
            name.Add("sweta");
            name.Add("shivam");

            // Console.WriteLine(mynumber.Capacity); //know capicity of program//if we increase the element then capicity increase by bouble of 4 sooo on
            foreach (int  item in mynumber)
            {
                Console.WriteLine(item);
            }
            foreach (string getdetail in name)
            {
                Console.WriteLine(getdetail);
            }
            Console.ReadLine();
        }
    }
}
