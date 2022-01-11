namespace _05.Peaks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private const string Single_Peak = "Lonely peak is the highest, peak index 0 and value {0}";
        private const string Peak_Output = "Peak index {0} and peak value {1}.";
        private const string Peaks_Doesnt_Exist = "There is no peaks!";

        static void Main(string[] args)
        {
            char[] splitChars = new char[] { '[', ',', ']' };
            int[] peaks = Console.ReadLine().Split(splitChars, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(peak => int.Parse(peak)).ToArray();

            if (peaks.Length == 1)
            {
                Console.WriteLine(string.Format(Single_Peak, peaks[0]));
                return;
            }

            Dictionary<int, int> peakIndexAndValue = new Dictionary<int, int>();

            int previousPeak = peaks[0];
            int currentPeak = 0;
            int nextPeak = 0;

            //1,2,1,3
            for (int i = 1; i < peaks.Length; i++)
            {
                currentPeak = peaks[i];
                nextPeak = int.MinValue;

                if (i <= peaks.Length - 2)
                {
                    nextPeak = peaks[i + 1];
                }

                if (currentPeak > previousPeak && currentPeak > nextPeak)
                {
                    peakIndexAndValue.Add(i, currentPeak);
                }

                previousPeak = currentPeak;
            }

            if (peakIndexAndValue.Count > 0)
            {
                PrintPeaks(peakIndexAndValue);
            }
            else
            {
                Console.WriteLine(Peaks_Doesnt_Exist);
            }
        }

        private static void PrintPeaks(Dictionary<int, int> peakIndexAndValue)
        {
            foreach (var peak in peakIndexAndValue)
            {
                Console.WriteLine(string.Format(Peak_Output, peak.Key, peak.Value));
            }
        }
    }
}