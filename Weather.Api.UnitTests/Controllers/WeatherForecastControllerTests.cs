﻿using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Weather.Api.Controllers;

namespace Weather.Api.UnitTests.Controllers;

[TestFixture]
public class WeatherForecastControllerTests
{
	private IMock<ILogger<WeatherForecastController>> _logger;

	[SetUp]
	public void TestSetup()
	{
		_logger = new Mock<ILogger<WeatherForecastController>>();
	}

	[Test]
	public void Test()
	{
		//Arrange

		var controller = new WeatherForecastController(_logger.Object);

		//Act
		var response = controller.Get();

		//Assert
		response.Should().BeOfType<WeatherForecast[]>();
	}
}