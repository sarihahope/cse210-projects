class Lecture : Event 
{

private string _speakerEvent;
private int _capacity;

    public Lecture(string _eventTitle, string _descriptiuon, DateTime _date, TimeSpan _time,string _street, string _city, string _state, string _zipCode, string _speakerEvent, int _capacity): 
        base(_eventTitle, _descriptiuon, _date, _time, _street, _city, _state, _zipCode)
    {
        this._speakerEvent = _speakerEvent;
        this._capacity = _capacity;
    }

    public override string FullDeatails()
    {
        return $"{EventDetailsFull()} \nType: Lecture \nSpeaker: {_speakerEvent} \nCapacity of Event: {_capacity}";
    }

    public override string ShortDetails()
    {
        return $"Type: Lecture\nEvent: {_eventTitle}\nDate: {_date}";
    }

} 