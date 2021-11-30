using CloudBench.Domain.Exceptions;

namespace CloudBench.Domain.ValueObjects;

public record CaseNote
{
  public CaseNoteId Id { get; }
  public CaseId CaseId { get; }
  public PersonId AuthorId { get; }
  public string Content { get; }
  public bool IsPublic { get; }
  public bool IsDeleted { get; init; }
  public DateTime CreatedAt { get; }

  public CaseNote(CaseNoteId id, CaseId caseId, PersonId authorId, string content, bool isPublic)
  {
    if (string.IsNullOrWhiteSpace(content))
      throw new EmptyCaseNoteContentException();
    Id = id;
    CaseId = caseId;
    AuthorId = authorId;
    Content = content;
    IsPublic = isPublic;
    IsDeleted = false;
    CreatedAt = DateTime.UtcNow;
  }
}