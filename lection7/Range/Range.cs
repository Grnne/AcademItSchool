namespace Range;

public class Range
{
    public double From { get; set; }

    public double To { get; set; }

    public Range(double from, double to)
    {
        From = from;
        To = to;
    }

    public double GetLength() => To - From;

    public bool IsInside(double number) => number >= From && number <= To;
}
