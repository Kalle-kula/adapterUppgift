using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Robot
    {
        Random generator = new Random();

        public void recharge()
        {
            int rechargeAmountHours = generator.Next(24) + 1;
            Console.WriteLine("Robot recharges " + rechargeAmountHours + " hours per night");
        }

        public void communicate()
        {
            int communicateAmountWords = generator.Next(10000) + 1;
            Console.WriteLine("Robot communicates " + communicateAmountWords + " words per day");
        }

        public void rolls()
        {
            int rollsAmountMeters = generator.Next(5000) + 1;
            Console.WriteLine("Robot rolls " + rollsAmountMeters + " meters per day");
        }
    }
}
