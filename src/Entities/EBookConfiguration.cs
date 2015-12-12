using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    class EBookConfiguration : EntityTypeConfiguration<EBook>
    {
        public EBookConfiguration()
        {
            ToTable("Books");

            Property(b => b.Title)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
