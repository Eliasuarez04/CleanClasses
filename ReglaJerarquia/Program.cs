//Código Sucio

class Animal
{
    public void Bark() { Console.WriteLine("Bark!"); }
}

//Código Limpio
class Animal
{
    public virtual void MakeSound() { Console.WriteLine("Animal sound!"); }
}

class Dog : Animal
{
    public override void MakeSound() { Console.WriteLine("Bark!"); }
}
