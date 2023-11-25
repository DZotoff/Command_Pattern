using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_strat
{
    // Determine command for turning the light off
    public class LightOff : Command
    {
        private Light light;

        public LightOff(Light light)
        {
            this.light = light;
        }

        public void Ex()
        {
            light.TurnOff();
        }
    }
}
