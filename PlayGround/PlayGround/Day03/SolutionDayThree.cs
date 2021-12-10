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

        private StringBuilder GammaRate { get; set; } = new StringBuilder();
        private StringBuilder EpsilonRate { get; set; } = new StringBuilder();


        private void SetUp()
        {
            Diagnostics = File.ReadAllLines("../../../Day03/InputDayThree.in").ToList();
        }

        public int Part1()
        {
            SetUp();


            for (int i = 0; i < Diagnostics[0].Length; i++)
            {
                GammaRate.Append(Diagnostics.Count(x => x[i] == '1') > Diagnostics.Count / 2 ? "1" : "0");
                EpsilonRate.Append(Diagnostics.Count(x => x[i] == '0') > Diagnostics.Count / 2 ? "1" : "0");
            }

            return Convert.ToInt32(EpsilonRate.ToString(), 2) * Convert.ToInt32(GammaRate.ToString(), 2);
        }

    }
}
