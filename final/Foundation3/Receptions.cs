class Reception: Event{


    private string _rsvp;


    public Reception (string _eventTitle, string _descriptiuon, DateTime _date, TimeSpan _time,string _street, string _city, string _state, string _zipCode, string _rsvp):
    base (_eventTitle, _descriptiuon, _date, _time, _street, _city, _state, _zipCode)
    {
        this._rsvp = _rsvp;
    }

    public override string FullDeatails()
    {
        return $"{EventDetailsFull()} \nType: Reception \nRSVP Email: {_rsvp}";
    }

    public override string ShortDetails()
    {
        return $"Type: Lecture\nEvent: {_eventTitle}\nDate: {_date}";
    }
}