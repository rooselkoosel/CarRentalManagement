using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace CarRentalManagement.Configurations.Entities
{
    public class MakeSeed : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id = 1,
                    Name = "BMW",
                    DateCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Make
                {
                    Id = 2,
                    Name = "TOYOTA",
                    DateCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
