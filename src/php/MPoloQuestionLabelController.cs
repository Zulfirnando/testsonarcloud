// Decompiled with JetBrains decompiler
// Type: MKT_POLOSYS_API.Controllers.MPoloQuestionLabelController
// Assembly: MKT_POLOSYS_API, Version=3.0.2021.1122, Culture=neutral, PublicKeyToken=null
// MVID: 0E9087E7-2B39-44D3-B7CE-E5CF7C87BA61
// Assembly location: D:\Z\SonarQube\Sample Test\sonarqube-scanner Test2\Object Deployment\POLO\PCR\API\MKT_POLOSYS_API.dll

using Microsoft.AspNetCore.Mvc;
using MKT_POLOSYS_API.Models;
using MKT_POLOSYS_API.Providers;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MKT_POLOSYS_API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MPoloQuestionLabelController : ControllerBase
  {
    [HttpGet("Data/Update")]
    [Produces("application/json", new string[] {})]
    public async Task<IActionResult> GetMPoloQuestionLabel()
    {
      MPoloQuestionLabelController questionLabelController = this;
      ProcessResultModel processResultModel = new ProcessResultModel();
      string parameterBody = "";
      using (StreamReader stream = new StreamReader(questionLabelController.Request.Body))
        parameterBody = await ((TextReader) stream).ReadToEndAsync();
      List<ProcessResultModel> questionLabel = new MMktPoloQuestionLabelProvider().getQuestionLabel(parameterBody);
      return questionLabel.Count != 0 ? (IActionResult) questionLabelController.Ok((object) questionLabel) : (IActionResult) questionLabelController.NotFound((object) questionLabel);
    }

    [HttpGet("{id}")]
    public string Get(int id) => "value";

    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
