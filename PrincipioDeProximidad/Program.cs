//Código Sucio

class Order
{
    public void PlaceOrder() { Console.WriteLine("Order placed."); }
}

class Invoice // Lejos de Order
{
    public void GenerateInvoice() { Console.WriteLine("Invoice generated."); }
}


//Código Limpio 

class Order
{
    public void PlaceOrder()
    {
        Console.WriteLine("Order placed.");
        GenerateInvoice();
    }

    private void GenerateInvoice()
    {
        Console.WriteLine("Invoice generated.");
    }
}
