using JwtApp.API.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JwtApp.API.Persistance.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x=>x.Category)
                        .WithMany(x => x.Products)
                            .HasForeignKey(x => x.CayegoryId);
        }
    }
}
