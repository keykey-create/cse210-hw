
public class Product
{
    private string _productName;
    private string _productID;
    private float _price;
    private int _quantity;

    public Product()
    {

    }

    public void SetProductName(string productname)
    {
        _productName = productname;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductID()
    {
        string idNumber = "";
        Random random = new();
        for (int i = 0; i < 8; i++)
        {
            idNumber += random.Next(9);
        }
        _productID = $"#{idNumber}";
    }

    public string GetProductID()
    {
        SetProductID();
        return _productID;
    }

    public void SetPrice( float price)
    {
        _price = price;
    }

    public float GetPrice()
    {
        return _price;
    }

    public void SetQuantity(int Quantity)
    {
        _quantity = Quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public float TotalPrice()
    {
        return _price * _quantity;
    }
}