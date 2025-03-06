//Código Limpio

class Car
{
    public string model;
    public string brand;
}

Car myCar = new Car();
myCar.model = "Model S";
myCar.brand = "Tesla";
Console.WriteLine("Car: " + myCar.brand + " " + myCar.model);


//Código Sucio

class Car
{
    public string Model { get; }
    public string Brand { get; }

    public Car(string model, string brand)
    {
        Model = model;
        Brand = brand;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Car: {Brand} {Model}");
    }
}

// Instancia de la clase Car
Car myCar = new Car("Model S", "Tesla");
myCar.DisplayInfo();
