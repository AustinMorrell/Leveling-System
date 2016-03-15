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

            while(true)
            {
                Console.WriteLine(Bob.Level);
                Console.WriteLine(Bob.EXP);
                Console.ReadLine();
                Bob.EXP++;
                if (Bob.EXP > Bob.Curve[Bob.Level])
                {
                    for (; Bob.EXP > Bob.Curve[Bob.Level];)
                    {
                        Bob.Level++;
                    }
                }
                Console.Clear();
            }

            Console.ReadLine();
        }
    }
}
