using CloudBench.Application.DTO;
using CloudBench.Application.Queries;
using CloudBench.Shared.Abstractions.Commands;
using CloudBench.Shared.Abstractions.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CloudBench.Api.Controllers;

public class CasesController : BaseController
{
  private readonly ICommandDispatcher _commands;
  private readonly IQueryDispatcher _queries;

  public CasesController(ICommandDispatcher commands, IQueryDispatcher queries)
  {
    _commands = commands;
    _queries = queries;
  }

  [HttpGet("{id:int}")]
  public async Task<ActionResult<CaseDto>> Get([FromRoute] GetCase query)
  {
    var result = await _queries.QueryAsync(query);
    return OkOrNotFound(result);
  }
}