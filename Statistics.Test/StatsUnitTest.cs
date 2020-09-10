using System;
using Xunit;
using Statistics;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatisticsComputer();
            var computedValues = statsComputer.ComputeStatistics(
                new List<___> { 1.5, 8.9, 3.2, 4.5 });
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedValues.Average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedValues.Max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedValues.Min - 1.5) <= epsilon);
        }
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatisticsComputer();
            var computedValues = statsComputer.ComputeStatistics(
                new List<___> { });
            Assert.True(float.IsNaN(computedValues.Average));
            Assert.True(float.IsNaN(computedValues.Max));
            Assert.True(float.IsNaN(computedValues.Min));
        }
    }
}
