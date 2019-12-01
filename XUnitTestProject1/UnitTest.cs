using BerlinClock;
using FluentAssertions;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest
    {
        private ITimeConverter timeConverter;
        public UnitTest()
        {
            timeConverter = new TimeConverter();
        }
        [Theory]
        [InlineData("13:17:01", "O\r\nRROO\r\nRRRO\r\nYYROOOOOOOO\r\nYYOO")]
        [InlineData("24:00", "Y\r\nRRRR\r\nRRRR\r\nOOOOOOOOOOO\r\nOOOO")]
        [InlineData("24:00:00", "Y\r\nRRRR\r\nRRRR\r\nOOOOOOOOOOO\r\nOOOO")]
        [InlineData("00:00:00", "Y\r\nOOOO\r\nOOOO\r\nOOOOOOOOOOO\r\nOOOO")]
        [InlineData("00:59:00", "Y\r\nOOOO\r\nOOOO\r\nYYRYYRYYRYY\r\nYYYY")]
        public void ShouldConvertTime(string time, string expectedResult)
        {
            // Act
            var res = timeConverter.convertTime(time);

            // Assert
            res.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("25:00:00")]
        [InlineData("-1:00:00")]
        [InlineData("1:61:00")]
        [InlineData("1:59:100")]
        public void ShouldThrowExceptionIfTimeIsOutOfBounds(string time)
        {
            Action act = () => timeConverter.convertTime(time);

            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData("25a:00:00")]
        [InlineData("00:00_")]
        [InlineData("nf:ff:ff")]
        public void ShouldThrowExceptionIfTimeIsMalFormed(string time)
        {
            Action act = () => timeConverter.convertTime(time);

            act.Should().Throw<ArgumentException>();
        }

        [Theory]
        [InlineData("00:00:00:000")]
        public void ShouldThrowExceptionIfContainsMiliseconds(string time)
        {
            Action act = () => timeConverter.convertTime(time);

            act.Should().Throw<ArgumentException>();
        }
    }
}
