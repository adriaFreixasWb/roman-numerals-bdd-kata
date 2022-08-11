using RomanNumerals.Domain;

namespace RomanNumerals.Test.Unit;

public class RomanNumeralShould
{
    [Theory]
    [InlineData("I",1)]
    [InlineData("V", 5)]
    public void Convert_Simple_Numbers(string expected, int arabic)
    {
        var roman = new RomanNumeral(arabic);
        Assert.Equal(expected, roman.Value);
    }
}