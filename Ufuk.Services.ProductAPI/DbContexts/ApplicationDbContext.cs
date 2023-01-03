using Microsoft.EntityFrameworkCore;

namespace Ufuk.Services.ProductAPI.DbContexts
{
    //3rd step.
    public class ApplicationDbContext : DbContext
    {
        //4th step.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
