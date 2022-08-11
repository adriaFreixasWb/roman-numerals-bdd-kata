namespace RomanNumerals.Domain;

public record RomanSybmols : RomanNumeral
{
    //L, C, D, M
    public static RomanNumeral None { get; } = new RomanSybmols(0, string.Empty);
    public static RomanNumeral I { get; } = new RomanSybmols(1, "I");
    public static RomanNumeral V { get; } = new RomanSybmols(5, "V");
    public static RomanNumeral X { get; } = new RomanSybmols(10, "X");
    public static RomanNumeral L { get; } = new RomanSybmols(50, "L");
    public static RomanNumeral C { get; } = new RomanSybmols(100, "C");
    public static RomanNumeral D { get; } = new RomanSybmols(500, "D");
    public static RomanNumeral M { get; } = new RomanSybmols(1000, "M");

    protected RomanSybmols(int arabic, string value) : base(arabic, value)
    {
    }
}
