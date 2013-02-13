//A company has name, address, phone number, fax
//number, web site and manager. The manager has
//first name, last name, age and a phone number.
//Write a program that reads the information about a
//company and its manager and prints them on the
//console.

using System;

class Program
{
    static void Main()
    {
        string companyName, adress, webSite, mFirstName, mLastName;
        int companyPhone, Fax, managerPhone;
        //companyName = "Parlakov's Co";
        //adress = "Sofia,Vladimir Vazov blvd";
        //webSite = "parlakov.ovo.bg";
        //mFirstName="Georgi";
        //mLastName = "Parlakov";
        //companyPhone = 0899474746;
        //Fax=123456;
        //managerPhone = companyPhone;

        Console.WriteLine("Please give the details asked:");
        Console.Write("Company Name:");
        companyName = Console.ReadLine();
        Console.Write("Adress:");
        adress= Console.ReadLine();
        Console.Write("Website:");
        webSite= Console.ReadLine();
        Console.Write("Manager First Name:");
        mFirstName= Console.ReadLine();
        Console.Write("Manager last name:");
        mLastName= Console.ReadLine();
        Console.Write("Company phone number:");
        while (!int.TryParse(Console.ReadLine(), out companyPhone)) { Console.WriteLine("Company phone number:"); }
        Console.Write("Company fax number:");
        while (!int.TryParse(Console.ReadLine(), out Fax)) { Console.WriteLine("Company fax number:"); }
        Console.Write("Company manager phone number:");
        while (!int.TryParse(Console.ReadLine(), out managerPhone)) { Console.WriteLine("Company manager phone number:"); }

        Console.WriteLine("Company:{0,50} \nadress: {1,50} \nPhone:{2,52} \nFax:{3,54} \nWebsite:{4,50} \nManager:{5,40} {6,9} \nManager phone:{7,44}", companyName, adress, companyPhone, Fax, webSite, mFirstName, mLastName, managerPhone);
    }
}

