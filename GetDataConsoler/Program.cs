using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetDataConsoler.WebService;

namespace GetDataConsoler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(Service1Client Client =new Service1Client())
                {
                    var Data = Client.GetStudents();
                    Console.WriteLine(typeof(Service1Client));
                    Console.WriteLine(Data.Students[1].Name);
                    Console.WriteLine("\n-----------------\n");
                    Console.WriteLine("First Student Name:");
                    Console.WriteLine(Client.GetFirstStudent().Name);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
    }
}
