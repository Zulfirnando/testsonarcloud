// Decompiled with JetBrains decompiler
// Type: MKT_POLOSYS_API.Controllers.MasterCustAcqController
// Assembly: MKT_POLOSYS_API, Version=3.0.2021.1122, Culture=neutral, PublicKeyToken=null
// MVID: 0E9087E7-2B39-44D3-B7CE-E5CF7C87BA61
// Assembly location: D:\Z\SonarQube\Sample Test\sonarqube-scanner Test2\Object Deployment\POLO\PCR\API\MKT_POLOSYS_API.dll

using Microsoft.AspNetCore.Mvc;
using MKT_POLOSYS_API.Models;
using MKT_POLOSYS_API.Providers;
using System.Collections.Generic;

namespace MKT_POLOSYS_API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MasterCustAcqController : ControllerBase
  {
    [HttpGet("Data/GetAll")]
    [Produces("application/json", new string[] {})]
    public ActionResult<List<MasterCustAcqViewModel>> Get() => ActionResult<List<MasterCustAcqViewModel>>.op_Implicit(new MasterCustAcqProvider().getAllMasterCUst());

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
