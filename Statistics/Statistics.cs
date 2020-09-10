using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    public struct ComputedStats
    {
        public float Average;
        public float Min;
        public float Max;
        public ComputedStats(float average,float Min,float Max)
        {
            this.Average = average;
            this.Min = Min;
            this.Max = Max;
        }
    }
    public class StatisticsComputer
    {
        public ComputedStats ComputeStatistics(List<float> data)
        {
            ComputedStats computedValues = new ComputedStats();
            if (data.Count != 0)
            {
                computedValues.Average = data.Average();
                computedValues.Min = data.Min();
                computedValues.Max = data.Max();
            }
            else
            {
                computedValues.Average = float.NaN;
                computedValues.Min = float.NaN;
                computedValues.Max = float.NaN;
            }
            return computedValues;
        }
    }
}

