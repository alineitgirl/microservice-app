using PlatformService.Models;

namespace PlatformService.Data;

public static class PrepDb
{
    public static void PrepPopulation(IApplicationBuilder builder)
    {
        using var serviceScope = builder.ApplicationServices.CreateScope();
        SeedData(serviceScope.ServiceProvider.GetRequiredService<AppDbContext>());
    }

    private static void SeedData(AppDbContext context)
    {
        if (!context.Platforms.Any())
        {
            Console.WriteLine("----->> Seeding Data");
            context.Platforms.AddRange(
                new Platform() {Name = "Dot Net", Publisher = "Microsoft", Cost = "Free"},
                new Platform() {Name = "PostgresSQL", Publisher = "Aka Russian Federation", Cost = "Free"},
                new Platform() {Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free"}
            );
            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("------> We have already have data");
        }
    }
}