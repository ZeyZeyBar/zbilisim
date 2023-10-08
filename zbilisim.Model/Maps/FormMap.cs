using Microsoft.EntityFrameworkCore.Metadata.Builders;
using zbilisim.Core.Maps;
using zbilisim.Model.Entities;

namespace zbilisim.Model.Maps
{
    public class FormMap:CoreMap<FormTable>
    {
        public override void Configure(EntityTypeBuilder<FormTable> builder)
        {
            builder.Property(x => x.NameSurname)
                .HasMaxLength(250)
                .IsRequired(true);

            builder.Property(x => x.Email)
                .HasMaxLength(250)
                .IsRequired(true);

            builder.Property(x => x.Message)
                .HasMaxLength(500)
                .IsRequired(true);
        }
    }
}
