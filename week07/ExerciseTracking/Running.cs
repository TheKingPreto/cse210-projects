public class Running : Activity
{
    private double _distanceKm;

    public Running(string date, int lengthInMinutes, double distanceKm)
        : base(date, lengthInMinutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance() => _distanceKm;
    public override double GetSpeed() => (_distanceKm / GetLengthInMinutes()) * 60;
    public override double GetPace() => GetLengthInMinutes() / _distanceKm;
}
