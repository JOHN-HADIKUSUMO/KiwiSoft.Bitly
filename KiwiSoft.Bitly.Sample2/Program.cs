using KiwiSoft.Bitly;
using KiwiSoft.Bitly.Models;
using KiwiSoft.Bitly.Interfaces;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection serviceCollection = new ServiceCollection();
serviceCollection.AddScoped<IShortener, Shortener>(x =>
    new Shortener(new SecurityConfiguration("Blc70wzstx9", "4fe1ecdbf176cd84aea34d332bed1646a7985c19"))
);

IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
IShortener shortener = serviceProvider.GetRequiredService<IShortener>();
ReturnURL result = shortener.Create("https://cmatskas.com/create-an-azure-ad-protected-api-that-calls-into-cosmosdb-with-azure-functions-and-net-core-3-1/");
Console.WriteLine(result.Url);
