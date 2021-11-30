using CloudBench.Shared.Abstractions.CaseData;
using CloudBench.Shared.Abstractions.Commands;

namespace CloudBench.Application.Commands;

public record CreateCase(int CaseId, int ProcessId, int RequesterId, ICaseData Data) : ICommand;