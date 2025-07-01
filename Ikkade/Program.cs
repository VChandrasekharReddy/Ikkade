// See https://aka.ms/new-console-template for more information

using Ikkade.model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

Console.WriteLine("Welcome to Ikkade Food Universe");
Console.WriteLine("This is a food ordering system for restaurants and customers.");
bool exit = false;
while (!exit)
{
    Console.WriteLine("Please select an option:");
    Console.WriteLine("1. Admin");
    Console.WriteLine("2. Biller");
    Console.WriteLine("3. Exit");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
               case 1:
            // Admin functionality
            Console.WriteLine("You Choosen the Admin Functionality please enter the credentials");
            Console.Write("Enter Admin User ID: ");
            string adminUserId = Console.ReadLine();
            Console.Write("Enter Password: ");
            string adminPassword = Console.ReadLine();
            Admin admin = new Admin
            {
                AdminUserId = adminUserId,
                Password = adminPassword
            };
            AdminDashbord(admin);
            break;
        case 2:
            // Biller functionality
            Console.WriteLine("You Choose the Biller Functionalaty so please give the Biller Credentials");
            Console.Write("Enter Biller User ID: ");
            string billerUserId = Console.ReadLine();
            Console.WriteLine("Enter the Biller Password: ");
            string billerPassword = Console.ReadLine();
            Biller biller = new Biller
            {
                BillerUserId = billerUserId,
                Password = billerPassword
            };
            BillerDashbord(biller);

            break;
        case 3:
            exit = true;
            Console.WriteLine("Exiting the application. Thank you!");
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}




void AdminDashbord(Admin admin)
{
    //
    
}


void BillerDashbord(Biller biller)
{

}







