public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime _date, int _lengthAcivity, double _speed):
    base(_date, _lengthAcivity)
    {
        this._speed = _speed;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60 / _speed;
    }

    public override string AcivityType()
    {
        return "Cyclying";
    }

    public override string Summery()
    {
        return $"{base.Summery()} - Speed {_speed:F1} km/h, Pace: {Pace():F1} min per mile";
    }
}