using CodeGenerator;
using CodeGenerator.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var serviceProvider = new ServiceCollection()
                        .AddDbContext<MyDBContext>()
                        .BuildServiceProvider();

var dbContext = serviceProvider.GetService<MyDBContext>();
if (dbContext != null)
{
    Company tCompany = new Company();
    tCompany.Name = "Test Company";
    dbContext.Add(tCompany);
    dbContext.SaveChanges();

    User tUser = new User();
    tUser.Name = "Test User";
    dbContext.Add(tUser);
    dbContext.SaveChanges();

    Console.WriteLine($"New Company Code: {tCompany.Code}");
    Console.WriteLine($"New User Code: {tUser.Code}");
}