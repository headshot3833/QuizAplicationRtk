using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizAplicationRtk.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.DAL.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Name).HasMaxLength(20).IsRequired();
        builder.Property(x => x.Password).HasMaxLength(20).IsRequired();
        builder.Property(x => x.Role).IsRequired();

        builder.HasData(new List<User>
        {
            new User
            {
            Id= 1,
            Name = "Admin",
            Password = "123456789",
            Role = "SuperAdmin"
            }
        });
    }
}
