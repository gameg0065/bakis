namespace UnitTestGeneration.Difficult.App;

// https://github.com/scourii/HieloCalculator/blob/main/Hielo/ConvertUnits.cs
// cy = 29, co = 2

public class UnitsConverter
{
    private decimal cmconverted { get; set; }

    private decimal onefoot = 12; // Used to divide to find the feet.

    public decimal PoundsToKilograms(decimal _pounds)
    {
        return _pounds / 2.20462262185m;
    }
    public decimal KilogramsToPounds(decimal kilograms)
    {
        return kilograms * 2.20462262185m;
    }
    public decimal InchesToCentimeters(decimal _converted)
    {
        return _converted * 2.54m;
    }
    public string CentimetersToInches(decimal centimeters)
    {
            
        cmconverted = centimeters / 2.54m;
        if(cmconverted >= onefoot)
        {
            decimal dividedbytwelve = Math.Round(cmconverted / 12, 2);
            string feet = dividedbytwelve.ToString();
            feet = feet.Replace(".", "'");
            return feet;
        }
        else
        {
            return cmconverted.ToString();
        }

    }
    public decimal CelsiusToFahrenheit(decimal celsius)
    {
        return celsius + 32 * 1.8m;
    }
    public decimal FahrenheitToCelsius(decimal fahrenheit)
    {
        return (fahrenheit - 32) / 1.8m;
    }
}