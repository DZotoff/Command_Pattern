using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_strat
{
    // Receiver class for the Light
    public class Light
    {
        public bool Is { get; private set; }

        public void TurnOn()
        {
            Is = true;
            Console.WriteLine("Light is ON");
        }

        public void TurnOff()
        {
            Is = false;
            Console.WriteLine("Light is OFF");
        }
    }

}
