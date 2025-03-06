//Código Sucio

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

//Código Limpio

class Price
{
    public decimal Value { get; }

    public Price(decimal value)
    {
        if (value < 0) throw new ArgumentException("Price cannot be negative.");
        Value = value;
    }
}

class Product
{
    public string Name { get; }
    public Price Price { get; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = new Price(price);
    }
}

