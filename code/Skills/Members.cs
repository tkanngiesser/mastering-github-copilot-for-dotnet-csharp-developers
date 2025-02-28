using System;

namespace Skills;

public class Members
{
    public string Name { get; set; }
    public string Email { get; set;}

    public int Age { get; set; }

    public Members(string name, string email, int age)
    {
        Name = name;
        Email = email;
        Age = age;
    }
}
