using Medium.Strategy.Strategies.Interfaces;

namespace Medium.Strategy.Strategies;

public class TaxSaoPauloStrategy : ITaxSaoPauloStrategy
{
    public void BillAsync()
    {
        Console.WriteLine("Geração nota fiscal São Paulo");
    }
}