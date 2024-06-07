using Microsoft.EntityFrameworkCore;
using PCMaster.Models;
using System;

namespace PCMaster.Repository
{
	public class SeedData
	{
		public static void SeedingData(DataContext _context)
		{
			_context.Database.Migrate();
			if (!_context.Products.Any())
			{
				CategoryModels Macbook = new CategoryModels { Name= "Macbook", Slug = "Macbook", Description= "Apple is Large Brand in the world", Status= 1};
				CategoryModels pc = new CategoryModels { Name= "pc", Slug = "pc", Description= "pc is Large Brand in the world", Status= 1};
				BrandModels apple = new BrandModels { Name = "Macbook", Slug = "Macbook", Description = "Apple is Large Brand in the world", Status = 1 };
				BrandModels samsung = new BrandModels { Name = "SamSung", Slug = "samsung", Description = "SamSung is Large Brand in the world", Status = 1 };
				_context.Products.AddRange(
					new ProductModels { Name = "Macbook", Slug = "macbook", Description = "Macbook is Best", Image = "1.jpg", Category = Macbook, Brand = apple, Price = 1233 },
					new ProductModels { Name = "pc", Slug = "pc", Description = "pc is Best", Image = "1.jpg", Category = pc, Brand = samsung, Price = 1233 }
				);
				_context.SaveChanges();
			}
		}
	}
}
	