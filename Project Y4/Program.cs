using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Y4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time;
            int hours, minutes;//Yo

            Console.WriteLine("ENTER A NUMBER:");
            time = int.Parse(Console.ReadLine());

            hours = time / 100;
            minutes = time % 100;
            Console.WriteLine("the time is" + hours + ":"  + minutes);
        }
    }
}
