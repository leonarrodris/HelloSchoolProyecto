using Microsoft.EntityFrameworkCore;
namespace HelloSchool.Models
{
public class PreRegistroContext : DbContext
{
public PreRegistroContext(DbContextOptions<PreRegistroContext> options) :
base(options)
{
}
public DbSet<PreRegistro> PreRegistros { get; set; }
}
}