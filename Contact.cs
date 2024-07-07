public class Contact : Person
{
    protected string? phoneNumber;
    protected string? email;

    public Contact() : base()
    {
    }

    public Contact(string fName, string lName, string pNumber, string eMail) : base(fName, lName)
    {
        phoneNumber = pNumber;
        email = eMail;
    }

    public string? PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }

    public string? EMail
    {
        get { return email; }
        set { email = value; }
    }

    public override void PrintDetails()
    {
        Console.WriteLine(firstName + " " + lastName);
        Console.WriteLine($"Phone: {PhoneNumber}");
        Console.WriteLine($"Email: {EMail}");
        Console.WriteLine("\n");
    }
}