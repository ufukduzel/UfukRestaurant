using Microsoft.EntityFrameworkCore;
using Ufuk.Services.ProductAPI.Models;

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
    }
}
