namespace CloudBench.Application.Commands;

public record AddCaseAttachment(int CaseId, int UploaderId, bool IsPublic, string ContentType,
  IEnumerable<byte> Content);