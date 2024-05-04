using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizAplicationRtk.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.DAL.Configurations;

public class AnswersConfiguration : IEntityTypeConfiguration<Answers>
{
    public void Configure(EntityTypeBuilder<Answers> builder)
    {
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.IsCorrect).IsRequired();

        builder.Property(x => x.AnswerText).IsRequired().HasMaxLength(50);
    }
}
