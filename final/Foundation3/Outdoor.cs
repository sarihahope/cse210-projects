class Outdoor : Event
{

    private string _weather;


    public Outdoor (string _eventTitle, string _descriptiuon, DateTime _date, TimeSpan _time,string _street, string _city, string _state, string _zipCode, string _weather):
    base (_eventTitle, _descriptiuon, _date, _time, _street, _city, _state, _zipCode)
    {
        this._weather = _weather;
    }

    public override string FullDeatails()
    {
        return $"{EventDetailsFull()} \nType: Outdoor \nWeather: {_weather}";
    }

        public override string ShortDetails()
    {
        return $"Type: Lecture\nEvent: {_eventTitle}\nDate: {_date}";
    }

}