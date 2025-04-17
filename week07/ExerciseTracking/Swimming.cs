public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50) / 1000.0; // meters to km
    public override double GetSpeed() => (GetDistance() / GetLengthInMinutes()) * 60;
    public override double GetPace() => GetLengthInMinutes() / GetDistance();
}
