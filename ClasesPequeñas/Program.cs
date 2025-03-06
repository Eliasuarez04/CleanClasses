//Código Sucio

class FirstName
{
    public string Value { get; set; }
}

class LastName
{
    public string Value { get; set; }
}

class User
{
    public FirstName Name { get; set; }
    public LastName Surname { get; set; }
}

//Código Limpio

class User
{
    public string FirstName { get; }
    public string LastName { get; }

    public User(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
