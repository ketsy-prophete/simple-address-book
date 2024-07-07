// Properties 
public class Person
{
    protected string? firstName;
    protected string? lastName;


    //Default constructor
    public Person()
    {
        firstName = "";
        lastName = "";
    }


    // Parameterized constructor 
    public Person(string fName, string lName)
    {
        firstName = fName;
        lastName = lName;
    }


    // Methods 
    public virtual void PrintDetails()
    {
        Console.WriteLine(firstName + lastName);
    }


    // Accessors 
    public string? FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string? LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
}