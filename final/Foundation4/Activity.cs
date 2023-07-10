using System;
using System.Collections.Generic;

public abstract class Activity
{

    private DateTime _date;
    public int _lengthAcivity;


    public Activity(DateTime _date, int _lengthAcivity)
    {
        this._date =_date;
        this._lengthAcivity = _lengthAcivity;
    }

    public virtual double Speed()
    {
        return 0;
    }

    public virtual double Distance()
    {
        return 0;
    }

    public virtual double Pace()
    {
        return 0;
    }

    public virtual string AcivityType()
    {
        return "Acivity";
    }


    public virtual string Summery()
    {
        return $"{_date}, {AcivityType()} {_lengthAcivity} min";
    }



}