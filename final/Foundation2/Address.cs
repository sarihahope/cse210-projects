class Address
{
        private string _streeAddress;
        private string _city;
        private string _state;
        private string _country;

        public Address(string _streeAddress, string _city, string _state, string _country)
        {
            this._streeAddress = _streeAddress;
            this._city = _city;
            this._state = _state;
            this._country = _country;
        }

        public string FullAddress()
        {
            return _streeAddress + "\n" + _city + ", " + _state + " " + _country;

        }

        public bool USAorNo()
        {
            return _country == "USA";
        }
}