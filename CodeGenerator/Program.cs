using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
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
    //For Benchmarking
    var summary = BenchmarkRunner.Run<BechmarkNew>();

    //For Actual Insertion
    /*Company tCompany = new Company();
    tCompany.Name = "Test Company";
    dbContext.Add(tCompany);
    dbContext.SaveChanges();

    User tUser = new User();
    tUser.Name = "Test User";
    dbContext.Add(tUser);
    dbContext.SaveChanges();

    Console.WriteLine($"New Company Code: {tCompany.Code}");
    Console.WriteLine($"New User Code: {tUser.Code}");*/
}

[MemoryDiagnoser]
public class BechmarkNew
{
    [Benchmark()]
    public void InsertWithCode()
    {
        var dbContext = new MyDBContext();
        Company tCompany = new Company();
        tCompany.Name = "Test Company";
        dbContext.Add(tCompany);
        dbContext.SaveChanges();
    }
    [Benchmark]
    public void InsertWithOutCode()
    {
        var dbContext = new MyDBContext();
        Company tCompany = new Company();
        tCompany.Name = "Test Company";
        dbContext.Add(tCompany);
        dbContext.SaveChangeWithoutCodeGenerator();
    }
}