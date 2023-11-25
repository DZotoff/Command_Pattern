using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_strat
{
    // Determine command for decreasing the thermostat temperature
    public class ThermDec : Command
    {
        private Thermostat therm;

        public ThermDec(Thermostat therm)
        {
            this.therm = therm;
        }

        public void Ex()
        {
            therm.DecTemp();
        }
    }
}
