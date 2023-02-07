using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ufuk.Services.Identity.Models;

namespace Ufuk.Services.Identity.DbContexts
{
    // 128th step.
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> // 130th step.
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
