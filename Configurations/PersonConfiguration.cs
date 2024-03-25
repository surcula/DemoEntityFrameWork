using DemoEntityFrameWork.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFrameWork.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasIndex(p => p.Pseudo).IsUnique();
            builder.Property(p => p.FirstName).HasMaxLength(50).HasDefaultValue("Jean");
            //builder.HasCheckConstraint("CK_PERSON_EMAIL","'EMAIL LIKE __%@__%._%'");
        }
    }
}
