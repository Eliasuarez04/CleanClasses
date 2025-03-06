//Código Sucio

string name = "John Doe";
string email = "john@example.com";
int age = 25;

Console.WriteLine(name + " - " + email + " - " + age);


//Código Limpio 

class User
{
    public string Name { get; }
    public string Email { get; }
    public int Age { get; }

    public User(string name, string email, int age)
    {
        Name = name;
        Email = email;
        Age = age;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"{Name} - {Email} - {Age} years old");
    }
}

// Uso de la clase
User user = new User("John Doe", "john@example.com", 25);
user.DisplayUserInfo();
