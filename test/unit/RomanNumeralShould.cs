using RomanNumerals.Domain;

namespace RomanNumerals.Test.Unit;

public class RomanNumeralShould
{
    [Theory]
    [InlineData("I",1)]
    [InlineData("V", 5)]
    [InlineData("X", 10)]
    [InlineData("L", 50)]
    [InlineData("C", 100)]
    [InlineData("D", 500)]
    [InlineData("M", 1000)]
    public void Convert_Simple_Numbers(string expected, int arabic)
    {
        var roman = new RomanNumeral(arabic);
        Assert.Equal(expected, roman.Value);
    }
}