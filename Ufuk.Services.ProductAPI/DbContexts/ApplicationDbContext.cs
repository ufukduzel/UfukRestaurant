using Microsoft.EntityFrameworkCore;
using Ufuk.Services.ProductAPI.Models.Dto;

namespace Ufuk.Services.ProductAPI.DbContexts
{
    //3rd step.
    public class ApplicationDbContext : DbContext
    {
        //4th step.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //8th step.
        public DbSet<Product> Products { get; set; }

        //9th step.
        //Package Manager Console (Default project: Services\Ufuk.Services.ProductAPI)
        //add-migration AddProductModelToDb
        //update-database

        //37th step.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
