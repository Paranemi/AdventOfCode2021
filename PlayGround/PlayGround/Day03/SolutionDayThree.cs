using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PlayGround.Day3
{
    public class SolutionDayThree
    {
        private List<string> Diagnostics { get; set; }

        private StringBuilder GammaRate { get; set; }
        private StringBuilder EpsilonRate { get; set; }

        private List<string> OxygenRate { get; set; }
        private List<string> Co2Rate { get; set; }

        public SolutionDayThree()
        {
            Diagnostics = File.ReadAllLines("../../../Day03/InputDayThree.in").ToList();
        }

        public int Part1()
        {
            GammaRate = new StringBuilder();
            EpsilonRate = new StringBuilder();

            for (int i = 0; i < Diagnostics[0].Length; i++)
            {
                GammaRate.Append(Diagnostics.Count(x => x[i] == '1') > Diagnostics.Count(x => x[i] == '0') ? "1" : "0");
                EpsilonRate.Append(Diagnostics.Count(x => x[i] == '1') > Diagnostics.Count(x => x[i] == '0') ? "0" : "1");
            }

            return Convert.ToInt32(EpsilonRate.ToString(), 2) * Convert.ToInt32(GammaRate.ToString(), 2);
        }

        public int Part2()
        {
            OxygenRate = Diagnostics;
            Co2Rate = Diagnostics;

            for (int i = 0; i < Diagnostics[0].Length; i++)
            {
                var mostCommonValue = OxygenRate.Count(x => x[i] == '1') >= OxygenRate.Count(x => x[i] == '0')? "1" : "0";

                OxygenRate = OxygenRate.FindAll(x => x[i] == char.Parse(mostCommonValue));

                if (OxygenRate.Count == 1)
                {
                    break;
                }
            }

            for (int i = 0; i < Diagnostics[0].Length; i++)
            {
                var leastCommonValue = Co2Rate.Count(x => x[i] == '0') <= Co2Rate.Count(x => x[i] == '1') ? "0" : "1";

                Co2Rate = Co2Rate.FindAll(x => x[i] == char.Parse(leastCommonValue));

                if (Co2Rate.Count == 1)
                {
                    break;
                }
            }

            return Convert.ToInt32(OxygenRate.First(), 2) * Convert.ToInt32(Co2Rate.First(), 2);
        }

    }
}
