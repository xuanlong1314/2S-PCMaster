using Microsoft.EntityFrameworkCore;
using PCMaster.Controllers;
using PCMaster.Models;

namespace PCMaster.Repository
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}
		public DbSet<BrandModels> Brands { get; set; }
		public DbSet<ProductModels> Products { get; set; }
		public DbSet<CategoryModels> Category { get; set; }
	}
}
