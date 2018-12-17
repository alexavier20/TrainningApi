using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainningApi.Domain.Entities;

namespace TrainningApi.Infrastructure.EntityConfig
{
    class ExampleItemConfig : IEntityTypeConfiguration<ExampleItem>
    {
        public void Configure(EntityTypeBuilder<ExampleItem> builder)
        {
            builder.Property("Id").HasField("ID_ExampleItem");
            builder.Property("Name").HasField("NAME");
            builder.Property("IsComplete").HasField("ISCOMPLETE");
        }
    }
}
