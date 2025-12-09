

public class Runnning : Activity
{
    private int _distance; // in meters
    public Runnning(string date, int length, int distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance / 1000;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}