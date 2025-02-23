using Hephaestus.DataApi.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hephaestus.DataApi
{
    public class ApplicationDbContext : IdentityDbContext<UserEntity, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
