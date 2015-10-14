using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Kalle = new Human();
            Robot Lasse = new Robot();
            IHumanBehaviour robotAdapter = new RobotAdapter(Lasse);

            Console.WriteLine("The human:");

            Kalle.sleep();
            Kalle.talk();
            Kalle.walk();
            Console.WriteLine();

            Console.WriteLine("The robot:");
            Lasse.recharge();
            Lasse.communicate();
            Lasse.rolls();
            Console.WriteLine();

            Console.WriteLine("The humaniod:");
            robotAdapter.sleep();
            robotAdapter.talk();
            robotAdapter.walk();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
