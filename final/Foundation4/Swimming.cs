public class Swimming : Activity
{
    private int _swimLaps;

    public Swimming(DateTime _date, int _lengthAcivity, int _swimLaps):
    base(_date, _lengthAcivity)
    {
        this._swimLaps = _swimLaps;
    }

    public override double Distance()
    {
        return _swimLaps * 50 / 1000.0;
    }

    public override double Pace()
    {
        return (double)base._lengthAcivity / Distance() / 60;
    }

    public override double Speed()
    {
        return Distance() / (double)base._lengthAcivity *60 / 1.609;
    }

        public override string Summery()
    {
        return $"{base.Summery()} - Speed {Speed():F1} mph, Pace: {Pace():F1} min per mile";
    }







    
}