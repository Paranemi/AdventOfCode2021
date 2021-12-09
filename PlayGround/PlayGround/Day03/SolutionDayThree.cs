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

        private string EpsilonRate { get; set; }
        private int EpsilonRateDecimal { get; set; }

        private StringBuilder GammaRate { get; set; } = new StringBuilder();
        private int GammaRateDecimal { get; set; }

        private void SetUp()
        {
            Diagnostics = File.ReadAllLines("../../../Day03/InputDayThree.in").ToList();
        }

        public int Part1()
        {
            SetUp();

            int bit1 = 0;
            int bit2 = 0;
            int bit3 = 0;
            int bit4 = 0;
            int bit5 = 0;
            int bit6 = 0;
            int bit7 = 0;
            int bit8 = 0;
            int bit9 = 0;
            int bit10 = 0;
            int bit11 = 0;
            int bit12 = 0;

            foreach (var item in Diagnostics)
            {
                bit1 += int.Parse(item.Substring(0, 1));
                bit2 += int.Parse(item.Substring(1, 1));
                bit3 += int.Parse(item.Substring(2, 1));
                bit4 += int.Parse(item.Substring(3, 1));
                bit5 += int.Parse(item.Substring(4, 1));
                bit6 += int.Parse(item.Substring(5, 1));
                bit7 += int.Parse(item.Substring(6, 1));
                bit8 += int.Parse(item.Substring(7, 1));
                bit9 += int.Parse(item.Substring(8, 1));
                bit10 += int.Parse(item.Substring(9, 1));
                bit11 += int.Parse(item.Substring(10, 1));
                bit12 += int.Parse(item.Substring(11, 1));
            }

            EpsilonRate = (bit1 > Diagnostics.Count / 2 ? 1 : 0).ToString() +
                          (bit2 > Diagnostics.Count / 2 ? 1 : 0).ToString() +
                          (bit3 > Diagnostics.Count / 2 ? 1 : 0).ToString() +
                          (bit4 > Diagnostics.Count / 2 ? 1 : 0).ToString() +
                          (bit5 > Diagnostics.Count / 2 ? 1 : 0).ToString() +
                          (bit6 > Diagnostics.Count / 2 ? 1 : 0).ToString() +
                          (bit7 > Diagnostics.Count / 2 ? 1 : 0).ToString() +
                          (bit8 > Diagnostics.Count / 2 ? 1 : 0).ToString() +
                          (bit9 > Diagnostics.Count / 2 ? 1 : 0).ToString() +
                          (bit10 > Diagnostics.Count / 2 ? 1 : 0).ToString() +
                          (bit11 > Diagnostics.Count / 2 ? 1 : 0).ToString() +
                          (bit12 > Diagnostics.Count / 2 ? 1 : 0).ToString();

            for (int i = 0; i < EpsilonRate.Length; i++)
            {
                GammaRate.Append(int.Parse(EpsilonRate.Substring(i, 1)) > 0 ? 0 : 1);
            }



            return Convert.ToInt32(EpsilonRate, 2) * Convert.ToInt32(GammaRate.ToString(), 2);
        }

    }
}
