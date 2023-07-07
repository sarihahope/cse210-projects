class Order
{
    private Custormer Custormer;
    private Product[] Products;
    private int _amountProducts;

    public Order (Custormer Custormer)
        {
            this.Custormer = Custormer;
            Products = new Product[10];
            _amountProducts = 0;
        }

        public void AddProduct(Product products)
        {
           Products[_amountProducts] = products;
            _amountProducts++;
        }

    public double GetTotalPrice()
    {
        double _totalPrice = 0.0;
        foreach (Product Product in Products)
        {
            if (Product != null)
            {
            _totalPrice += Product.PriceSum();
            }
            }
            if (Custormer.USAorNo())
                {
                  _totalPrice += 5.0;
                }
            else
                {
                 _totalPrice += 35.0;
                }
            return _totalPrice;
    }

    public string GetPackingLabel()
    {
        string _packingLabel = "";
        foreach (Product Product in Products)
        {
            if (Product != null)
            {
                _packingLabel += Product.NameProduct() + " (" + Product.ProductId() + ")\n";
            }
        }
            return _packingLabel;
    }
    
    public string GetShippingLabel()
    {
            string _shippingLabel = "";
            _shippingLabel += Custormer.RetriveName() + "\n";
            _shippingLabel += Custormer.RetriveAdress().FullAddress() + "\n";
                return _shippingLabel;
}
}
