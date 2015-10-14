using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Human : IHumanBehaviour
    {
        Random generator = new Random();

        public void sleep()
        {
            int sleepAmountHours = generator.Next(24) + 1;
            Console.WriteLine("Human sleeps " + sleepAmountHours + "hours per night");
        }

        public void talk()
        {
            int talkAmountWords = generator.Next(10000) + 1;
            Console.WriteLine("Human says " + talkAmountWords + " words per day");
        }

        public void walk()
        {
            int walkAmountPaces = generator.Next(5000) + 1;
            Console.WriteLine("Human walks " + walkAmountPaces + " paces per day");
        }
    }
}
