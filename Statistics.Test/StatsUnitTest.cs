using System;
using Xunit;
using Statistics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatisticsComputer();
            var computedValues = statsComputer.ComputeStatistics(
                new List<float> { 1.5F, 8.9f, 3.2F, 4.5F });
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedValues.Average - 4.525F) <= epsilon);
            Assert.True(Math.Abs(computedValues.Max - 8.9F) <= epsilon);
            Assert.True(Math.Abs(computedValues.Min - 1.5F) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatisticsComputer();
            var computedValues = statsComputer.ComputeStatistics(
                new List<float> { });
            Assert.True(float.IsNaN(computedValues.Average));
            Assert.True(float.IsNaN(computedValues.Max));
            Assert.True(float.IsNaN(computedValues.Min));
        }
    }
}
