using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Day2
{
    public class SolutionDayTwo
    {
        private List<string> Forward { get; set; }
        private int Forwards { get; set; }

        private List<string> Up { get; set; }
        private int Ups { get; set; }

        private List<string> Down { get; set; }
        private int Downs { get; set; }

        private readonly char[] charsToTrimForward = { 'f', 'o', 'r', 'w', 'a', 'r', 'd' };
        private readonly char[] charsToTrimUp = { 'u', 'p' };
        private readonly char[] charsToTrimDown = { 'd', 'o', 'w', 'n' };

        private List<string> NavigationCommands { get; set; }

        public SolutionDayTwo()
        {
            NavigationCommands = File.ReadAllLines("../../../Day02/InputDayTwo.in").ToList();
        }

        public int Part1()
        {
            Forward = NavigationCommands.Where(x => x.Contains("forward")).ToList();

            foreach (var item in Forward)
            {
                Forwards += int.Parse(item.Trim(charsToTrimForward));
            }

            Up = NavigationCommands.Where(x => x.Contains("up")).ToList();

            foreach (var item in Up)
            {
                Ups += int.Parse(item.Trim(charsToTrimUp));
            }

            Down = NavigationCommands.Where(x => x.Contains("down")).ToList();

            foreach (var item in Down)
            {
                Downs += int.Parse(item.Trim(charsToTrimDown));
            }

            int depths = Ups - Downs;

            if(depths < 0)
            {
                depths = depths * -1;
            }

            return Forwards * depths;
        }

        public int Part2()
        {
            int horizontal = 0;
            int depth = 0;
            int aim = 0;

            foreach (var item in NavigationCommands)
            {
                if (item.Contains("forward"))
                {
                    horizontal += int.Parse(item.Trim(charsToTrimForward));
                    depth += int.Parse(item.Trim(charsToTrimForward)) * aim;

                }
                else if (item.Contains("down"))
                {
                    aim += int.Parse(item.Trim(charsToTrimDown));
                }
                else
                {
                    aim -= int.Parse(item.Trim(charsToTrimUp));
                }
            }

            return horizontal * depth;
        }
    }
}
