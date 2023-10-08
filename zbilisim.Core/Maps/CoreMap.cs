using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using zbilisim.Core.Entitiy;

namespace zbilisim.Core.Maps
{
    public abstract class CoreMap<T> : IEntityTypeConfiguration<T> where T : CoreEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x=>x.ID);
            builder.Property(x=>x.CreateDate).IsRequired(false);
            builder.Property(x => x.UpdateDate).IsRequired(false);
        }
    }
}
