using Microsoft.EntityFrameworkCore;
using TrainningApi.Domain.Entities;
using TrainningApi.Infrastructure.EntityConfig;

namespace TrainningApi.Infrastructure.Context
{
    public class TrainningApiContext : DbContext
    {
        public TrainningApiContext(DbContextOptions<TrainningApiContext> options) : base(options)
        {

        }

        public DbSet<ExampleItem> ExampleItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExampleItemConfig());
        }
    }
}
