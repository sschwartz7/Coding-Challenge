using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Coding_Challenge
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
       base(options){ }
    }
}
