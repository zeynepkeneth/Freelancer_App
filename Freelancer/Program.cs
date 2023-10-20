// See https://aka.ms/new-console-template for more information

using Freelancer.Entities;
using Freelancer.ValueObjects;
using Freelancer;


NotepadServices notepadServices = new();

Console.Write("Name:");
string name = Console.ReadLine();

Console.Write("surname:");
string surname = Console.ReadLine();

Console.Write("phone number:");
string PhoneNumber = Console.ReadLine();

freelancer myFreelancer = new freelancer
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTime.Now,
    FirstName = "John",
    LastName = "Doe",
    WorkExperience = "5 years of experience",
    Reviews = new List<Review>()
    {
        new Review { Text = "Excellent freelancer!", Point = 5 },
        new Review { Text = "Great!", Point = 4 },

    },

};
Customer customer1 = new Customer
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTimeOffset.Now,
    FirstName = name,
    LastName = surname,
    PhoneNumber = PhoneNumber,

};
Customer customer2 = new Customer
{
    Id = Guid.NewGuid(), 
    CreatedOn = DateTime.Now, 
    FirstName = "John",
    LastName = "Doe", 
    PhoneNumber = "555-555-5555" 
};

NotepadServices notepadService = new();
notepadServices.SaveToNotepad(customer2);
notepadServices.SaveToNotepad(customer1);
notepadService.SaveToNotepad(myFreelancer);

string customerData= notepadService.GetOnNotepad("/Users/banugenel/Projects/Freelancer/Freelancer/Customers.txt");
string[] splittedLines = customerData.Split("\n",StringSplitOptions.RemoveEmptyEntries);
List<Customer> customers = new();
foreach(var line in splittedLines)
{
    Customer customer = new();
    customer.SetValuesCSV(line);
    customers.Add(customer);
}