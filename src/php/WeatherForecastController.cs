// Decompiled with JetBrains decompiler
// Type: MKT_POLOSYS_API.Controllers.WeatherForecastController
// Assembly: MKT_POLOSYS_API, Version=3.0.2021.1122, Culture=neutral, PublicKeyToken=null
// MVID: 0E9087E7-2B39-44D3-B7CE-E5CF7C87BA61
// Assembly location: D:\Z\SonarQube\Sample Test\sonarqube-scanner Test2\Object Deployment\POLO\PCR\API\MKT_POLOSYS_API.dll

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MKT_POLOSYS_API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    private static readonly string[] Summaries = new string[10]
    {
      "Freezing",
      "Bracing",
      "Chilly",
      "Cool",
      "Mild",
      "Warm",
      "Balmy",
      "Hot",
      "Sweltering",
      "Scorching"
    };
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger) => this._logger = logger;

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
      Random rng = new Random();
      return (IEnumerable<WeatherForecast>) Enumerable.Range(1, 5).Select<int, WeatherForecast>((Func<int, WeatherForecast>) (index => new WeatherForecast()
      {
        Date = DateTime.Now.AddDays((double) index),
        TemperatureC = rng.Next(-20, 55),
        Summary = WeatherForecastController.Summaries[rng.Next(WeatherForecastController.Summaries.Length)]
      })).ToArray<WeatherForecast>();
    }
  }
}
