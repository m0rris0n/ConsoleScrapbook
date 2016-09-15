using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Main
{
    class Program
    {
        enum States { OPEN, OPENING, STOPPED_WHEN_OPENING, CLOSING, STOPPED_WHEN_CLOSING, CLOSED };
        #region GarageDelete

        string[] input = { "button_clicked", "cycle_complete", "button_clicked", "button_clicked", "button_clicked", "button_clicked", "cycle_complete" };

        States currentstate = States.CLOSED;

        public void runDoorScript()
        {

            foreach (string item in input)
            {


                Console.WriteLine("Door: {0}", currentstate);
                Console.WriteLine(">{0}", item);


                switch (currentstate)
                {
                    case States.OPEN:
                        if (item == "button_clicked")
                            currentstate = States.CLOSING;
                        else
                            currentstate = States.OPEN;
                        break;
                    case States.OPENING:
                        if (item == "button_clicked")
                            currentstate = States.STOPPED_WHEN_OPENING;
                        else
                            currentstate = States.OPEN;
                        break;
                    case States.STOPPED_WHEN_OPENING:
                        if (item == "button_clicked")
                            currentstate = States.CLOSING;
                        else
                            currentstate = States.STOPPED_WHEN_OPENING;
                        break;
                    case States.CLOSING:
                        if (item == "button_clicked")
                            currentstate = States.STOPPED_WHEN_CLOSING;
                        else
                            currentstate = States.CLOSED;
                        break;
                    case States.STOPPED_WHEN_CLOSING:
                        if (item == "button_clicked")
                            currentstate = States.OPENING;
                        else
                            currentstate = States.STOPPED_WHEN_CLOSING;
                        break;
                    case States.CLOSED:
                        if (item == "button_clicked")
                            currentstate = States.OPENING;
                        else
                            currentstate = States.CLOSED;
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine("Door: {0}", currentstate);
        }


        #endregion


    }
} 
