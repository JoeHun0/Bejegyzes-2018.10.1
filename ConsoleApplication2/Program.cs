using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
     
            List<Bejegyzes> list = new List<Bejegyzes>();
            list.Add(new Bejegyzes ("akárki", "Valami"));
            list.Add(new Bejegyzes("akárki2", "Valami2"));
            Console.WriteLine("Kérek egy számot.");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
        }
    }
}
