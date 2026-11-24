using EventHub.Context;
using Microsoft.EntityFrameworkCore;

namespace EventHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext dbContext = new AppDbContext();

            dbContext.Database.Migrate();

            Console.WriteLine("EventHubDb created successfully!");
        }
    }
}
