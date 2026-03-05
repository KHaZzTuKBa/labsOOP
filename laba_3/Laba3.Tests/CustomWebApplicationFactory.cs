using System.Linq;
using Laba3.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Laba3.Tests;

public class CustomWebApplicationFactory : WebApplicationFactory<Program>
{
	protected override void ConfigureWebHost(IWebHostBuilder builder)
	{
		builder.ConfigureServices(services =>
		{
			// Удаляем реальный AppDbContext (PostgreSQL)
			var descriptor = services.SingleOrDefault(
				d => d.ServiceType == typeof(DbContextOptions<AppDbContext>));

			if (descriptor != null)
			{
				services.Remove(descriptor);
			}

			// Подменяем на InMemory БД для функциональных тестов
			services.AddDbContext<AppDbContext>(options =>
				options.UseInMemoryDatabase("TestDb"));
		});
	}
}

