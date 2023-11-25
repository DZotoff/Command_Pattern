using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_strat
{
    // Receiver class for the Thermostat
    public class Thermostat
    {
        public int Temp = 20;

        public void IncTemp()
        {
            Temp++;
            Console.WriteLine($"Thermostat temperature increased to {Temp}");
        }

        public void DecTemp()
        {
            Temp--;
            Console.WriteLine($"Thermostat temperature decreased to {Temp}");
        }
    }
}
