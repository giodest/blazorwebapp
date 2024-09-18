using Microsoft.EntityFrameworkCore;
namespace blazorwebapp.Model
{
	public class AppDbContext : DbContext
	{
		protected readonly IConfiguration Configuration;


		public AppDbContext(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
		}

		public DbSet<Oggetto> Oggetti { get; set; }
	}
}