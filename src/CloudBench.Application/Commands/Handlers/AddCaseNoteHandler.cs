using CloudBench.Application.Exceptions;
using CloudBench.Domain.Repositories;
using CloudBench.Domain.ValueObjects;
using CloudBench.Shared.Abstractions.Commands;
using CloudBench.Shared.Abstractions.Queries;

namespace CloudBench.Application.Commands.Handlers;

public class AddCaseNoteHandler : ICommandHandler<AddCaseNote>
{
  private readonly ICaseRepository _repository;
  private readonly IQueryDispatcher _queryDispatcher;

  public AddCaseNoteHandler(ICaseRepository repository, IQueryDispatcher queryDispatcher)
  {
    _repository = repository;
    _queryDispatcher = queryDispatcher;
  }
  
  public async Task HandleAsync(AddCaseNote command)
  {
    var @case = await _repository.GetAsync(command.CaseId);

    if (@case is null)
      throw new CaseNotFoundException(command.CaseId);
   
    var caseNote = new CaseNote(Guid.NewGuid(), command.CaseId, command.AuthorId, command.Content, command.IsPublic);
    @case.AddNote(caseNote);

    await _repository.UpdateAsync(@case);
  }
}