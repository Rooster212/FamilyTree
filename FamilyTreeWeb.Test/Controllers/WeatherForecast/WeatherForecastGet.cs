using FamilyTreeWeb.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using System.Linq;
using Xunit;

namespace FamilyTreeWeb.Test
{
    public class WeatherForecastGet
    {
        [Fact]
        public void ReturnsTheCorrectNumberOfItems()
        {
            var mockLog = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(mockLog.Object);

            var weatherForecasts = controller.Get();

            Assert.Equal(5, weatherForecasts.Count());
        }
    }
}
