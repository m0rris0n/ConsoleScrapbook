using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Main
{
    class Lightswitch
    {
        private bool[] Switches = null;
        int maxSwitches;

        public void switchRun()
        {
            Console.WriteLine("How many switches?");
            string maxSwitchesStr = Console.ReadLine();
            while (!int.TryParse(maxSwitchesStr, out maxSwitches))
            {
                Console.Clear();
                Console.WriteLine("How many switches? (Please enter a number this time)");
                maxSwitchesStr = Console.ReadLine();
            }
            Switches = new bool[maxSwitches];



        }

        public void pressSwitches(int x, int y, ref bool[] switches)
        {
            for(int i = x;i< y;i++)
            {
                switches[i] = !switches[i];
            }
        }

    }
}
