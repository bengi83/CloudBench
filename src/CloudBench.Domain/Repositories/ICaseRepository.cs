using CloudBench.Domain.Entities;
using CloudBench.Domain.ValueObjects;

namespace CloudBench.Domain.Repositories;

public interface ICaseRepository
{
  Task<Case> GetAsync(CaseId id);
  Task AddAsync(Case @case);
  Task UpdateAsync(Case @case);
}