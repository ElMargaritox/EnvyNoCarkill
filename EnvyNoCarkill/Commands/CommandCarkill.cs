using Rocket.API;
using Rocket.Unturned.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvyNoCarkill.Commands
{
    internal class CommandCarkill : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Both;

        public string Name => "carkill";

        public string Help => "plugin by margarita";

        public string Syntax => String.Empty;

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            var instance = EnvyNoCarkillPlugin.Instance;

            if (instance.CarkillEnabled)
            {
                instance.CarkillEnabled = false;
                UnturnedChat.Say(caller, "Desactivaste el daño al atropellar");
            }
            else
            {
                instance.CarkillEnabled = true;
                UnturnedChat.Say(caller, "Desactivaste el daño al atropellar");
            }
        }
    }
}
