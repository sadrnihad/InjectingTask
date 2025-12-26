using Microsoft.EntityFrameworkCore;
using MVCProniaApp.Models;

namespace MVCProniaApp.DAL
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> optionsBuilder) : base(optionsBuilder)
		{

		}
		public DbSet<Slide> Sliders { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Blog> Blogs { get; set; }
	}
}