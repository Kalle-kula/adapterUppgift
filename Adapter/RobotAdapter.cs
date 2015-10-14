using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class RobotAdapter : IHumanBehaviour
    {
        Robot theRobot;

        public RobotAdapter(Robot humanoid)
        {
            theRobot = humanoid;
        }
        public void sleep()
        {
            theRobot.recharge();
        }

        public void talk()
        {
            theRobot.communicate();
        }

        public void walk()
        {
            theRobot.rolls();
        }
    }
}
