using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sending
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            while (i >= 10)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.WriteLine("Incrementation",j);
                }i++;
            }
        }
    }
}
