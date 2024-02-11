using Alyo.Hub2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Alyo.Hub2.Data.Data;

public class HubDbContext : DbContext
{
    public DbSet<Asset> Assets => Set<Asset>();
}