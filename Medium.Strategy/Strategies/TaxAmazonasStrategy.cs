using Medium.Strategy.Strategies.Interfaces;

namespace Medium.Strategy.Strategies;

public class TaxAmazonasStrategy : ITaxAmazonasStrategy
{
    public void Bill()
    {
        Console.WriteLine("Geração nota fiscal Amazonas");
    }
}