using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class2 :Shivam
    {
       public int getdata() 
        {
            //string mess = "hii bor";
            int mes = 45565;
            
            return mes;
        }
       
    }
}






------------------------------------program.cs-----------------------------------------------



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    interface Shivam
    {
       int getdata();
    }

    /*interface Rohit
    {

        showdata();
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            Class2 obj1 = new Class2();
            int aa= obj1.getdata();
            Console.WriteLine(aa);
           // obj1.showdata();
       
            Console.ReadLine();
        }
    }
}
