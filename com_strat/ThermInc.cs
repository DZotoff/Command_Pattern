using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_strat
{
    // Determine command for increasing the thermostat temperature
    public class ThermInc : Command
    {
        private Thermostat therm;

        public ThermInc(Thermostat therm)
        {
            this.therm = therm;
        }

        public void Ex()
        {
            therm.IncTemp();
        }
    }
}
