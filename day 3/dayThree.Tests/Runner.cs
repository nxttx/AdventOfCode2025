using dayThree.import;
using Shouldly;

namespace dayThree.Tests;

public class Runner
{
    [Fact]
    public void RunFirstTest()
    {
        var importer = new Importer();
        var joltageBanks = importer.Import();

        var total = 0;
        foreach (var bank in joltageBanks)
        {
            total += bank.MaxJoltage();
        }
        Console.WriteLine(total);
        total.ShouldBe(17445);
    }
    
    [Fact]
    public void RunSecondTest()
    {
        var importer = new Importer();
        var joltageBanks = importer.Import();

        long total = 0;
        foreach (var bank in joltageBanks)
        {
            total += bank.MaxJoltage(12);
        }
        Console.WriteLine(total);
        total.ShouldNotBe(1724785965569207289);
    }
}