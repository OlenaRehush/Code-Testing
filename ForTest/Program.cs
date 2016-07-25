using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new AlgoService();
            var b = new DataService(-2);

            //b.AddItem(1);
            //b.AddItem(2);

            //Console.WriteLine(b.GetElementAt(1));

            Console.ReadKey();
        }
    }
}
