using Rocket.Core.Plugins;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger = Rocket.Core.Logging.Logger;

namespace EnvyNoCarkill
{
    public class EnvyNoCarkillPlugin : RocketPlugin
    {
        public static EnvyNoCarkillPlugin Instance { get; set; }
        public bool CarkillEnabled { get; set; }
        protected override void Load()
        {
            Instance = this;
            Logger.Log("Plugin By Margarita#8172");
            DamageTool.damagePlayerRequested += DamageTool_damagePlayerRequested;
            CarkillEnabled = false;
        }

        private void DamageTool_damagePlayerRequested(ref DamagePlayerParameters parameters, ref bool shouldAllow)
        {
            if(parameters.cause == EDeathCause.VEHICLE & !CarkillEnabled)
            {
                shouldAllow = false;
            }
        }

        protected override void Unload()
        {
            DamageTool.damagePlayerRequested -= DamageTool_damagePlayerRequested;
        }
    }
}
