using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_strat
{
    // Determine command for turning the light on
    public class LightOn : Command
    {
        private Light light;

        public LightOn(Light light)
        {
            this.light = light;
        }

        public void Ex()
        {
            light.TurnOn();
        }
    }
}
