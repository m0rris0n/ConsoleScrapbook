using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.BusGossip
{
    class BusGossip
    {
        public List<Bus> buses;
        public int steps;
        public List<Bus> gossipCluster;

        public BusGossip()
        {
            steps = 0;
            gossipCluster = new List<Bus>();
        }


        public bool checkClue()
        {
            foreach(Bus bus in buses)
            {
                if (bus.CluedIn == false)
                    return false;
            }
            return true;
        }

        public void move()
        {
            foreach(Bus bus in buses)
            {
                if (bus.Gossiping == false)
                    bus.Time++;
                else
                    bus.Gossiping = false;
            }
        }

        public void clusterCheck()
        {
            foreach(Bus bus in buses)
            {

            }
        }

        public void stopSort()
        {
            bool repeat;
            do
            {
                repeat = false;
                for(int i = 0;i<buses.Count();i++)
                {
                    while (buses.ElementAt(i).getStop() > buses.ElementAt(i + 1).getStop())
                    {
                        repeat = true;
                        Bus hold = buses.ElementAt(i);
                        buses.RemoveAt(i);
                        buses.Add(hold);
                    }
                }
            } while (repeat);
        }

        public void gossip()
        {
            for(int i = 0;i<buses.Count();i++)
            {
                foreach(Bus bus in gossipCluster)
                {
                    if(bus.Gossips[i] == true)
                    {
                        foreach (Bus deepBus in gossipCluster)
                        {
                            deepBus.Gossips[i] = true;
                            
                        }
                        break;

                    }
                }
            }
        }


    }

    class Bus
    {
        public int Id { get; set; }
        public bool[] Gossips { get; set; }
        public List<int> Route { get; set; }
        public bool CluedIn { get; set; }
        public int Stop { get; set; }
        public int Time { get; set; }
        public bool Gossiping { get; set; }

        
        public Bus(int buses, List<int> route, int id)
        {
            Id = id;
            Route = route;
            Gossips = new bool[buses];
            Gossips[Id] = true;
            Time = 0;
            Stop = route.First();
            Gossiping = false;
        }

        public int getStop()
        {
            int i = 0;
            while(i < Time)
            {
                foreach (int element in Route)
                {
                    if (i == Time)
                        return element;
                    i++;
                }
            }
            return -1;
        }
    }

}
