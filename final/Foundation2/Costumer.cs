class Custormer
{

private string _name;
private Address _address;

    public Custormer(string _name, Address _address)
    {
        this._name = _name;
        this._address = _address;
    }

    public string RetriveName()
    {
        return _name;
    }

    public Address RetriveAdress()
    {
        return _address;
    }

    public bool USAorNo()
    {
        return _address.USAorNo();
    }



}