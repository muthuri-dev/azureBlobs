using DocumentMgtSys.Core.Aggregates.FilesAg;
using DocumentMgtSys.Core.Aggregates.UsersAg;
using Microsoft.EntityFrameworkCore;

namespace DocumentMgtSys.Infrastructure.AppDbContext;

public class DocsMgtContext : DbContext
{
    protected DocsMgtContext()
    {
    }

    public DbSet<AppUser> AppUsers { get; set; }

    public DbSet<AppFile> AppFiles { get; set; }
}