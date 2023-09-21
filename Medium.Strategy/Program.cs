// See https://aka.ms/new-console-template for more information

using Medium.Strategy;
using Medium.Strategy.Strategies;
using Medium.Strategy.Strategies.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = CreateDefaultBuilder().Build();
var _taskExecution = host.Services.GetService<ITaxExecution>();
if(_taskExecution is not null) _taskExecution.GenerateAsync("SP");

host.Run(); return;

IHostBuilder CreateDefaultBuilder()
{
    return Host.CreateDefaultBuilder()
        .ConfigureServices((services) =>
        {
            services
                .AddScoped<ITaxExecution, TaxExecution>()
                .AddScoped<ITaxSaoPauloStrategy, TaxSaoPauloStrategy>()
                .AddScoped<ITaxAmazonasStrategy, TaxAmazonasStrategy>();
        });
}