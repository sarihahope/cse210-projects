public class Running : Activity
{
    private double _distence;

    public Running(DateTime _date, int _lengthAcivity, double _distence):
    base(_date, _lengthAcivity)
    {
        this._distence = _distence;
    }

    public override double Distance()
    {
        return _distence;
    }

    public override double Pace()
    {
        return (double)base._lengthAcivity / _distence / 60;
    }

    public override double Speed()
    {
        return _distence / (double)base._lengthAcivity* 60 / 1.609;
    }

    public override string AcivityType()
    {
        return "Running";
    }

    public override string Summery()
    {
        return $"{base.Summery()} - Distence {_distence:F1} miles, Speed {Speed():F1} mph, Pace: {Pace():F1} min per mile";
    }

}