using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leveling_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Bob = new Player();
            Bob.LevelCurve();
            foreach(int i in Bob.Curve)
            {
                Console.WriteLine(Bob.Curve[i] + "\n");
            }
            Console.ReadLine();
        }
    }
}
