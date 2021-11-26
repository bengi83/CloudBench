using CloudBench.Domain.Exceptions;

namespace CloudBench.Domain.ValueObjects;

public record CaseNote
{
  public CaseId CaseId { get; }
  public PersonId AuthorId { get; }
  public string Content { get; }
  public bool IsPublic { get; }

  public CaseNote(CaseId caseId, PersonId authorId, string content, bool isPublic)
  {
    if (string.IsNullOrWhiteSpace(content))
      throw new EmptyCaseNoteContentException();
    CaseId = caseId;
    AuthorId = authorId;
    Content = content;
    IsPublic = isPublic;
  }
}