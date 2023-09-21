using Medium.Strategy.Strategies.Interfaces;

namespace Medium.Strategy.Strategies;

public class TaxAmazonasStrategy : ITaxAmazonasStrategy
{
    public void BillAsync()
    {
        Console.WriteLine("Geração nota fiscal Amazonas");
    }
}