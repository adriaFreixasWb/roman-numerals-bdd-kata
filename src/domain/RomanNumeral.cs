namespace RomanNumerals.Domain;
public class RomanNumeral
{
    public string Value { get; }
    public RomanNumeral(int Arabic)
    {
        Value = ConvertToRoman(Arabic);
    }

    private string ConvertToRoman(int arabic)
    {
        if (arabic < 1)
        {
            return string.Empty;
        }
        if(arabic > 1)
        {
            return "" + RomanSybmols.V;
        }
        return ""+RomanSybmols.I;
    }
}
