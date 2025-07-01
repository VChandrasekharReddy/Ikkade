// See https://aka.ms/new-console-template for more information

using Ikkade.model;
using Ikkade.service;
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



//Admin Dashbord for admin operations 
void AdminDashbord(Admin admin)
{

    //
    if(new AdminLoginService().AdminAtunticate(admin)){
        Console.WriteLine($"welcome Mr.{admin.Name} : here are the choise to choose :");    
        bool login = true;
        while (login)
        {
            Console.WriteLine("1)BillerRegister");
            //Console.WriteLine("2)UpdateBiller");
            //Console.WriteLine("3)AdminRegister");
            Console.WriteLine("4)Update Your Profile");
            //Console.WriteLine("5)Get Tuday Order History"); 
            //Console.WriteLine("6)Get all Ordres History");
            //Console.WriteLine("7)Print all orders");
            //Console.WriteLine("8)list all billers");
            //Console.WriteLine("9)Delete Admin");
            Console.WriteLine("0)Exit\n:-");
            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 0:
                    login = false;
                    break;
                case 1:
                    Console.WriteLine("You Choose to creat a new Biller Account so give the biller Data");
                    Console.WriteLine("Enter the Biller UserId : ");
                    string billerUserId = Console.ReadLine();
                    Console.WriteLine("Enter the Biller Name : ");
                    string billerName = Console.ReadLine();
                    Console.WriteLine("Entre the Biller Mobile number");
                    string billerMobile = Console.ReadLine();
                    Console.WriteLine("Enter the Password : ");
                    string billerPassword = Console.ReadLine();
                    Console.WriteLine("Enter the E-Mail : ");
                    string billeremail = Console.ReadLine();
                    Biller biller = new Biller
                    {
                        BillerUserId = billerUserId,
                        Name = billerName,
                        Password = billerPassword,
                        Email = billeremail,
                        Phone = billerMobile
                    };
                    BillerRegisterationMethod(biller);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Console.WriteLine("you choose to update you profile Enter the field you want to update other wise just press enter");
                    Console.WriteLine();
                    Admin newadmin;
                    newadmin = ReadAdminData();
                    updateAdmin(admin, newadmin);
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine("asdfasdf");
                    break;
            }
        }

    }
    else
    {
        Console.WriteLine("Error while login");
    }
}


//method for creting the biller 
void BillerRegisterationMethod(Biller biller)
{
    //
    if(new BillerRegisterService().billerRegistration(biller))
    {
        Console.WriteLine($"{biller.Name} register sucussfully...\n\n\n");
    }
    else
    {
        Console.WriteLine(" error occer while registering");
    }

}


//to read the Adin data to Update the Admin
Admin ReadAdminData()
{
    Admin admin = new Admin();

    Console.Write("AdminUserId: ");
    admin.AdminUserId = Console.ReadLine();

    Console.Write("Name: ");
    admin.Name = Console.ReadLine();

    Console.Write("Email: ");
    admin.Email = Console.ReadLine();

    Console.Write("Password: ");
    admin.Password = Console.ReadLine();

    Console.Write("Phone: ");
    admin.Phone = Console.ReadLine();
    return admin;
}











void updateAdmin(Admin oldAdmin, Admin newAdmin)
{

}

























//biller dashbord for operations
void BillerDashbord(Biller biller)
{
    if(new BillerManagementService().AuthunticateBiller(biller))
    {
        Console.WriteLine("login");
    }
    else
    {
        Console.WriteLine("error");
    }


}







