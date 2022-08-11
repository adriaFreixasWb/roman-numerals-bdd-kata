namespace RomanNumerals.Domain;
public record RomanNumeral
{
    public int ArabicValue { get; }
    public string Value { get; }
    public RomanNumeral(int Arabic)
    {
        ArabicValue = Arabic;
        Value = ConvertToRoman(Arabic);
    }
    protected RomanNumeral(int arabic, string value)
    {
        ArabicValue = arabic;
        Value = value;
    }

    public override string ToString() => 
        Value;

    private string ConvertToRoman(int arabic)
    {
        if (arabic < RomanSybmols.I.ArabicValue)
        {
            return string.Empty;
        }
        if (arabic > RomanSybmols.X.ArabicValue)
        {
            return RomanSybmols.L.Value;
        }
        if (arabic > RomanSybmols.V.ArabicValue)
        {
            return RomanSybmols.X.Value;
        }
        if (arabic > RomanSybmols.I.ArabicValue)
        {
            return RomanSybmols.V.Value;
        }
        return RomanSybmols.I.Value;
    }
}
