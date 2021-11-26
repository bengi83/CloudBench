using CloudBench.Shared.Abstractions.CaseData;

namespace CloudBench.Application.Commands;

public record CreateCase(int ProcessId, int RequesterId, ICaseData Data);