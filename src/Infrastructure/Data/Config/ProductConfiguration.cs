using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Config
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Is required properties can be implemented here or at entities class files.

            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);  

            builder.Property(x => x.Price).IsRequired().HasPrecision(18, 2);

            //PictureUri string is already nullable but can be implemented like this inside the configuration file.
            builder.Property(x => x.PictureUri).IsRequired(false);

            //Foreign key properties can be implemented inside this config file but it is also not necessary due to navigation properties we added at entities class files.
            builder.HasOne(x => x.Category).WithMany().HasForeignKey(x => x.CategoryId);

            builder.HasOne(x => x.Brand).WithMany().HasForeignKey(x => x.BrandId);
        }
    }
}
