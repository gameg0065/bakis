namespace UnitTestGeneration.Difficult.App;

// https://github.com/LandSharkFive/StatOne/blob/main/StatOne/Util.cs
// cy = 20, co = 6
public static class StatOne
{
    public static double Variance(this double[] source)
    {
        int n = source.Count();
        double mean = source.Average();
        double m2 = 0;

        foreach (double x in source)
        {
            double delta = x - mean;
            m2 += delta * delta;
        }

        return m2 / n;
    }

    // Standard Deviation is the square root of the variance.  Denoted sigma.
    public static double StandardDeviation(this double[] source)
    {
        return Math.Sqrt(source.Variance());
    }

    public static double Range(this IEnumerable<double> source)
    {
        return source.Max() - source.Min();
    }

    public static double Covariance(double[] source, double[] other)
    {
        int n = source.Count();

        double avgSource = source.Average();
        double avgOther = other.Average();
        double covariance = 0;

        for (int i = 0; i < n; i++)
        {
            covariance += (source[i] - avgSource) * (other[i] - avgOther);
        }

        return covariance / n;
    }

    public static double Pearson(double[] source, double[] other)
    {
        return Covariance(source, other) /
               (source.StandardDeviation() * other.StandardDeviation());
    }


    public static double StandardScore(double value, double mean, double std)
    {
        return (value - mean) / std;
    }



    public static double GetXIntercept(double slope, double yIntercept)
    {
        return -yIntercept / slope;
    }

    public static double GetY(double x, double slope, double yIntercept)
    {
        return slope * x + yIntercept;
    }


    // Return slope and yIntercept.  
    // y = mx + b
    public static double GetSlopeIntercept(double[] source, double[] other, out double yIntercept)
    {
        int n = source.Count();
        double sumX = 0;
        double sumY = 0;
        double sumXX = 0;
        double sumXY = 0;

        for (int i = 0; i < n; i++)
        {
            double x = source[i];
            double y = other[i];
            sumX += x;
            sumY += y;
            sumXX += x * x;
            sumXY += x * y;
        }

        double delta = n * sumXX - sumX * sumX;

        yIntercept = (sumXX * sumY - sumX * sumXY) / delta;

        // slope
        return (n * sumXY - sumX * sumY) / delta;
    }


    public static double Correlation(double[] source, double[] other)
    {
        int n = source.Count();
        double sumX = 0;
        double sumY = 0;
        double sumXX = 0;
        double sumXY = 0;
        double sumYY = 0;

        for (int i = 0; i < n; i++)
        {
            double x = source[i];
            double y = other[i];
            sumX += x;
            sumY += y;
            sumXX += x * x;
            sumYY += y * y;
            sumXY += x * y;
        }

        // correlation
        return (n * sumXY - sumX * sumY) /
               System.Math.Sqrt((n * sumXX - sumX * sumX) * (n * sumYY - sumY * sumY));
    }

    // RSquared is correlation squared.

    public static double RSquared(double cor)
    {
        return cor * cor;
    }

    public static double RSquared(double[] source, double[] other)
    {
        double cor = Correlation(source, other);
        return cor * cor;
    }

    // Chi-Squared. Are two random variables dependent or independent?
    // Total observed equals Total Expected.  
    public static double ChiSquared(double[] observed, double[] expected)
    {
        double result = 0;
        for (int i = 0; i < observed.Length; i++)
        {
            double delta = observed[i] - expected[i];
            result += (delta * delta) / expected[i];
        }

        return result;
    }

    public static double Phi(double x)
    {
        // constants
        const double a1 = 0.254829592;
        const double a2 = -0.284496736;
        const double a3 = 1.421413741;
        const double a4 = -1.453152027;
        const double a5 = 1.061405429;
        const double p = 0.3275911;

        // Save the sign of x
        int sign = 1;
        if (x < 0)
        {
            sign = -1;
        }

        x = Math.Abs(x) / Math.Sqrt(2.0);

        // A&S formula 7.1.26
        double t = 1.0 / (1.0 + p * x);
        double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);

        return 0.5 * (1.0 + sign * y);
    }
}