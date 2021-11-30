using CloudBench.Domain.Entities;
using CloudBench.Domain.ValueObjects;
using CloudBench.Shared.Abstractions.CaseData;

namespace CloudBench.Domain.Factories;

public interface ICaseFactory
{
  Case Create(CaseId caseId, ProcessId processId, PersonId requesterId, ICaseData data);
}