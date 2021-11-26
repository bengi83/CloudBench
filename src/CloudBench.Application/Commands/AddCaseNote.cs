namespace CloudBench.Application.Commands;

public record AddCaseNote(int CaseId, int AuthorId, bool IsPublic, string Content);