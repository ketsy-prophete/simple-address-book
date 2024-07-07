List<Person> contactList = new List<Person>();

bool continueProgram = true;
while (continueProgram)
{
    Console.WriteLine("\n");

    DisplayOptions();

    Console.Write("_________________\nEnter your choice: ");
    string choice = Console.ReadLine() ?? "";

    switch (choice)
    {
        case "1":
            Console.Write("CREATE NEW CONTACT...\n");
            Console.WriteLine(CreateContact());
            break;
        case "2":
            Console.Write("_________________\nVIEW ALL CONTACTS... \n");
            Console.WriteLine("\n");
            ViewContact();
            break;
        case "3":
            Console.Write("Exiting Address Book...");
            continueProgram = false;
            break;
    }
}

void DisplayOptions()
{
    string list = "1. Create New Contact\n2. View All Contacts\n3. Exit";
    Console.WriteLine(list);
}

string CreateContact()
{
    Console.WriteLine("What is the contact's first name? ");
    string firstName = Console.ReadLine() ?? "";

    Console.WriteLine("What is the contact's last name? ");
    string lastName = Console.ReadLine() ?? "";

    Console.WriteLine("What is the contact's phone number? ");
    string phoneNumber = Console.ReadLine() ?? "";

    Console.WriteLine("What is the contact's email? ");
    string email = Console.ReadLine() ?? "";

    Contact newContact = new Contact(firstName, lastName, phoneNumber, email);
    contactList.Add(newContact);

    Console.WriteLine("\n");
    string message = "New Contact Added!";
    return message;
}

void ViewContact()
{
    foreach (Person personName in contactList)
    {
        personName.PrintDetails();
    }
}