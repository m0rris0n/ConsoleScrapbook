using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Main
{
    class Builder
    {
        public bool[,] bluePrints(int height)
        {
            bool[,] plan = input(height);
            bool isVal = frameWorkIsValid(plan);
            if (isVal == false)
            {
                do
                {
                    Console.WriteLine("This design is invalid, please submit a new design.");
                    plan = input(height);
                    isVal = frameWorkIsValid(plan);
                }
                while (!isVal);
            }
            
            return plan;
        }
                 
        bool[,] input(int height)
        {
            Console.WriteLine("Please enter the basic plan for your house, floor by floor.");
            int width = 0;
            
            //list to hold the input floor strings in correct order
            var floorStack = new List<string>(); 
            
            //reads each floor and adds to list
            //runs for times stated in method argument
            for(int i =0;i< height;i++)
            {
                string floor = Console.ReadLine();
                floorStack.Add(floor);
                if (floor.Length > width)
                    width = floor.Length;
            }

            //Builds array based on the longest string and given height
            bool[,] frameWork = new bool[width, height];
            //fills array with false
            for (int i = 0; i < width; i++)
                for (int k = 0; k < height; k++)
                    frameWork[i, k] = false;
            
            //Feeds the characters from the string list into the array//
            int x = 0;
            int y = 0;
            floorStack.ForEach(delegate (string s)
            {
                foreach (char c in s)
                {
                    if (c != 32) //ASCII 32 == " "
                        frameWork[x, y] = true;
                    x++;

                }
                x = 0;
                y++;
            });

            return frameWork;
        }

        bool frameWorkIsValid(bool[,] frameWork)
        {

            for (int i = 0; i < frameWork.GetLength(0); i++)
            {
                bool isStacked = false;
                for (int k = 0; k < frameWork.GetLength(1); k++)
                {
                    if (frameWork[i, k] == true)
                        isStacked = true;
                    else
                    {
                        if (isStacked == true)
                        {
                            return false;
                        }
                    }
                }
            }        


            return true;
        }

        void construction(bool[,] frameWork)
        {
            for (int i = 0; i < frameWork.GetLength(0); i++)
            {
                for (int k = 0; k < frameWork.GetLength(1); k++)
                {
                    
                }
            }
        }


    }
}
