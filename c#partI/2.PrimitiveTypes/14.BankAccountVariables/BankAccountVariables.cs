using System;
/* A bank account has a holder name (first name, middle name and last name), 
 * available amount of money (balance), bank name, IBAN, BIC code and 3 credit 
 * card numbers associated with the account. Declare the variables needed to keep 
 * the information for a single bank account using the appropriate data types and 
 * descriptive names */

class BankAccountVariables
{
    static void Main()
    {
        string firstName, middleName, sirName, bankName,IBAN;
        decimal balance;
        ushort BIC;
        long creditCard1, creditCard2, creditCard3;

        firstName = "Georgi";
        middleName = "Veselinov";
        sirName = "Parlakov";
        bankName = "DSK Bank";
        IBAN = "BG01 4597 4465 4569 6697";
        BIC = 9913;
        creditCard1 = 4321567845674432;
        creditCard2 = 32165498774512;
        creditCard3 = 9875123465479997;
        balance = 1000.987m;

        Console.WriteLine("Name is   {0}  {1}  {2},   has account in bank \n{3} ",firstName,middleName,sirName,bankName);
        Console.WriteLine("IBAN: {0,44} BIC: {1}",IBAN,BIC);
        Console.WriteLine("Associated cards:\n{0,60}\n{1,60}\n{2,60}",creditCard1,creditCard2,creditCard3);
        Console.WriteLine("Balance is {0,45:f2} EUR", balance);
        

    }
}

