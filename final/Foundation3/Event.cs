using System;

class Event {



    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;
    public string _eventTitle;
    private string _descriptiuon;
    public DateTime _date;
    private TimeSpan _time;
    
    public Event(string _eventTitle, string _descriptiuon, DateTime _date, TimeSpan _time,string _street, string _city, string _state, string _zipCode)
    {
        this._street = _street;
        this._city = _city;
        this._state = _state;
        this._zipCode = _zipCode;
        this._eventTitle = _eventTitle;
        this._descriptiuon = _descriptiuon;
        this._date = _date;
        this._time = _time;
    }

    public virtual string EventDetailsFull()
    {
    return $"Event: {_eventTitle} \n Descrption: {_descriptiuon} \n Date: {_date} \n Time: {_time}\n {_street}, {_city}, {_state} {_zipCode}";        
    }

    public virtual string ShortDetails()
    {
        return $"Type of Event: {_eventTitle} \nDate: {_date}";
    }

    public virtual string FullDeatails()
    {
        return EventDetailsFull();
    }
}

