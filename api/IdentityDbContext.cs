using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Daedalus.Api
{
    public class IdentityDataContext(DbContextOptions<IdentityDataContext> options) : IdentityDbContext(options)
    {
    }
}
