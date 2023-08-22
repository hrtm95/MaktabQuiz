using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaktabQuiz.Models.Configs
{
    public class ProductEntityType : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.CreationDate).IsRequired();
            builder.ToTable("Products");
        }
    }
}
