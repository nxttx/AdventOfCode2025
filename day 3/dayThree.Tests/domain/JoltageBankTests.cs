using dayThree.domain;
using Shouldly;

namespace dayThree.Tests.domain;

public class JoltageBankTests
{
    
    // In 987654321111111, you can make the largest joltage possible, 98, by turning on the first two batteries.
    // In 811111111111119, you can make the largest joltage possible by turning on the batteries labeled 8 and 9, producing 89 jolts.
    // In 234234234234278, you can make 78 by turning on the last two batteries (marked 7 and 8).
    // In 818181911112111, the largest joltage you can produce is 92.
    [Theory]
    [InlineData("987654321111111", 98)]
    [InlineData("811111111111119", 89)]
    [InlineData("234234234234278", 78)]
    [InlineData("818181911112111", 92)]
    public void Test1(string input, int expected)
    {
        var bank = new JoltageBank(input);
        var max = bank.MaxJoltage(2);
        max.ShouldBe(expected);
    }
    
    
    // In 987654321111111, the largest joltage can be found by turning on everything except some 1s at the end to produce 987654321111.
    // In the digit sequence 811111111111119, the largest joltage can be found by turning on everything except some 1s, producing 811111111119.
    // In 234234234234278, the largest joltage can be found by turning on everything except a 2 battery, a 3 battery, and another 2 battery near the start to produce 434234234278.
    // In 818181911112111, the joltage 888911112111 is produced by turning on everything except some 1s near the front.
    [Theory]
    [InlineData("987654321111111", 987654321111)]
    [InlineData("811111111111119", 811111111119)]
    [InlineData("234234234234278", 434234234278)]
    [InlineData("818181911112111", 888911112111)]
    public void Test2(string input, long expected)
    {
        var bank = new JoltageBank(input);
        var max = bank.MaxJoltage(12);
        max.ShouldBe(expected);
    }


    
}