using RentACarBlazor.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarBlazor.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    Id = 1,
                    Name = "Prius"
                },
                new Model
                {
                    Id = 2,
                    Name = "Vitz"
                },
                new Model
                {
                    Id = 3,
                    Name = "3 Series"
                },
                new Model
                {
                    Id = 4,
                    Name = "X5"
                }
            );
        }
    }
}
