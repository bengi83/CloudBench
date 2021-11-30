using CloudBench.Domain.Entities;
using CloudBench.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CloudBench.Infrastructure.EF.Config;

public class WriteConfiguration : IEntityTypeConfiguration<Case>, IEntityTypeConfiguration<CaseNote>
{
  public void Configure(EntityTypeBuilder<Case> builder)
  {
    builder.HasKey(c => c.Id);

    builder
      .Property(c => c.Id)
      .HasConversion(id => id.Value, id => new CaseId(id));

    builder.HasMany(typeof(CaseNote), "_notes");

    builder.ToTable("Cases");
  }

  public void Configure(EntityTypeBuilder<CaseNote> builder)
  {
    builder.HasKey(cn => cn.Id);

    builder
      .Property(cn => cn.Id)
      .HasConversion(id => id.Value, id => new CaseNoteId(id));
    builder
      .Property(cn => cn.CaseId)
      .HasConversion(id => id.Value, id => new CaseId(id));
    builder
      .Property(cn => cn.AuthorId)
      .HasConversion(id => id.Value, id => new PersonId(id));
    builder
      .Property(cn => cn.Content);
    builder
      .Property(cn => cn.IsPublic);
    builder
      .Property(cn => cn.IsDeleted);
    builder
      .Property(cn => cn.CreatedAt);

    builder
      .ToTable("CaseNotes");
  }
}