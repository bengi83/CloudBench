using CloudBench.Domain.Factories;
using CloudBench.Domain.Repositories;
using CloudBench.Shared.Abstractions.Commands;

namespace CloudBench.Application.Commands.Handlers;

internal sealed class CreateCaseHandler : ICommandHandler<CreateCase>
{
  private readonly ICaseFactory _factory;
  private readonly ICaseRepository _cases;

  public CreateCaseHandler(ICaseFactory factory, ICaseRepository cases)
  {
    _factory = factory;
    _cases = cases;
  }

  public async Task HandleAsync(CreateCase command)
  {
    var (caseId, processId, requesterId, data) = command;

    var @case = _factory.Create(caseId, processId, requesterId, data);
    await _cases.AddAsync(@case);
  }
}