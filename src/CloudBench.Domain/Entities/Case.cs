using CloudBench.Domain.Exceptions;
using CloudBench.Domain.ValueObjects;

namespace CloudBench.Domain.Entities;

public class Case
{
  public CaseId Id { get; }

  private readonly ProcessId _processId;
  private ProcessState _state;
  private readonly PersonId _requester;
  private CaseData _data;
  private DateTime _createdDate;

  private readonly List<CaseNote> _notes = new();

  internal Case(CaseId id, ProcessId processId, ProcessState state, PersonId requester, CaseData data,
    DateTime createdDate)
  {
    Id = id;
    _processId = processId;
    _state = state;
    _requester = requester;
    _data = data;
    _createdDate = createdDate;
  }

  public void UpdateState(ProcessState newState)
  {
    if (newState.ProcessId != _processId)
      throw new MismatchedProcessState(newState, _processId);
    _state = newState;
  }

  public void UpdateData(CaseData data)
  {
    _data = data;
  }

  public void AddNote(CaseNote note)
  {
    _notes.Add(note);
  }
}