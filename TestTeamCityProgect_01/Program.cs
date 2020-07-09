using System;
using FluentAssertions;
using NUnit.Framework;

namespace TestTeamCityProgect_01
{
    public class NUnitTest
    {
        [Test]
        public void DataTimeTest()
        {
            var startTime = DateTime.Now;
            Console.WriteLine("Hello World!");
            System.Threading.Thread.Sleep(TimeSpan.FromMinutes(3));
            var endTime = DateTime.Now;
            startTime.Should().BeBefore(endTime);
        }

        [Test]
        public void DataTime_PassTest()
        {
            var startTime = DateTime.Now;
            Console.WriteLine("This is test is passed!");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
            var endTime = DateTime.Now;
            startTime.Should().BeBefore(endTime);
        }

        [Test]
        public void DataTime_WarningTest()
        {
            Console.WriteLine("Start test.");
            var startTime = DateTime.Now;
            Console.WriteLine("This is test is worried!");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
            var endTime = DateTime.Now;
            Warn.If(startTime < endTime, "Not important validation.");
            startTime.Should().BeBefore(endTime, "Very important validation.");
            Console.WriteLine("Stop test.");
        }

        [Test]
        [Ignore("IGNORE")]
        public void DataTime_FailTest()
        {
            var startTime = DateTime.Now;
            Console.WriteLine("This is test is failed!");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
            var endTime = DateTime.Now;
            startTime.Should().BeAfter(endTime);
        }
    }
}
