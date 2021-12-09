using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PlayGround.Day1
{
    public class SolutionDayOne
    {
        private List<int> Depths { get; set; }
        private List<int> SummedDepths { get; set; } = new List<int>();

        public int LastNumber { get; set; } = 0;

        private void SetUpInput()
        {
            Depths = File.ReadAllLines("../../../Day1/InputDayOne.in").Select(x => int.Parse(x)).ToList();
        }

        public int Part1()
        {
            SetUpInput();

            int increases = 0;
            LastNumber = Depths.First();


            foreach (var item in Depths)
            {
                if (item > LastNumber)
                {
                    increases++;
                }
                LastNumber = item;
            }

            return increases;
        }

        public int Part2()
        {
            SetUpInput();

            int increases = 0;
            for (int i = 0; i < Depths.Count; i++)
            {
                try
                {
                    int sumOfThree = Depths[i] + Depths[i + 1] + Depths[i + 2];
                    SummedDepths.Add(sumOfThree);
                }
                catch(Exception e)
                {
                    LastNumber = SummedDepths.First();

                    foreach (var item in SummedDepths)
                    {
                        if (item > LastNumber)
                        {
                            increases++;
                        }
                        LastNumber = item;
                    }

                    Console.WriteLine("OutOfRangeException: " + e);
                    return increases;
                }
            }
            return 0;
        }
    }
}
