using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();

            Console.ReadLine();
        }          
    }
}
