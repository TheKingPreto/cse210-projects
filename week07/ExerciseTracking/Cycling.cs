public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(string date, int lengthInMinutes, double speedKph)
        : base(date, lengthInMinutes)
    {
        _speedKph = speedKph;
    }

    public override double GetSpeed() => _speedKph;
    public override double GetDistance() => (_speedKph / 60) * GetLengthInMinutes();
    public override double GetPace() => 60 / _speedKph;
}
