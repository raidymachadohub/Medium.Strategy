using Medium.Strategy.Strategies.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Medium.Strategy;

public class TaxExecution : ITaxExecution
{
    private readonly IServiceProvider _serviceProvider;

    private readonly Dictionary<string, Func<IServiceScope, ITaxStrategy>> _strategies =
        new()
        {
            { "AM", scope => scope.ServiceProvider.GetRequiredService<ITaxAmazonasStrategy>() },
            { "SP", scope => scope.ServiceProvider.GetRequiredService<ITaxSaoPauloStrategy>() }
        };

    public TaxExecution(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    public void Generate(string code)
    {
        if (!_strategies.TryGetValue(code, out var getStrategy))
        {
            throw new NotImplementedException("UF not found");
        }
        
        using var scope = _serviceProvider.CreateScope();
        var strategy = getStrategy(scope);
        strategy.Bill();
    }
}