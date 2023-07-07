class Product
{

    private string _name;
    private string _productId;
    private double _price;
    private int _qaunity;
    
    public Product(string _name, string _productId, double _price, int _qaunity)
    {

        this._name = _name;
        this._productId = _productId;
        this._price = _price;
        this._qaunity = _qaunity;
    }

    public string NameProduct()
    {
        return _name;
    }

    public string ProductId()
    {
        return _productId;
    }

    public double PriceSum()
    {
        return _price * _qaunity;
    }

}