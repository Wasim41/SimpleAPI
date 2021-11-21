using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController _weatherForcast;
        [Fact]
        public void GetReturnValue()
        {
            _weatherForcast = new WeatherForecastController();
            var obj = _weatherForcast.Get(1);
            Assert.Equal("Wasim Shaikh", obj.Value);
        }
    }
}
