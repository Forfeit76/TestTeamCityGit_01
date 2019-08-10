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
    }
}
