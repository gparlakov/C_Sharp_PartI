using System;

class VariablesForRecord
{
    static void Main()
    {
        string firstName, familyName, IDnumber,IDnumber2;  /*IDnumber - номер лична карта декларирам го като стринг, защото 
                                                            * едва ли ще се събира или изважда номерът на личната карта, 
                                                            * евентуално може да се сравнява, но string могат да се сравняват 
                                                            * дали са еднакви*/
        ushort employeeID;                                /* декларирам го с ushort, тъй като условието казва номера от 
                                                           * (27560000 to 27569999) само последните 4 цифри се променят, 
                                                           * така че ushort e достатъчен */
        char gender;

        firstName = "Иван";
        familyName = "Денкооглу";
        IDnumber = "234567891";
        IDnumber2 = "234567891";
        Console.WriteLine(IDnumber==IDnumber2);          // доказателство за по-горното :)
        employeeID = 1;
        gender = 'm';
        Console.WriteLine("Името на работника е {0} {1}, пол({4}), номер ЛК: {2}\nИдентификационен номер: {3}",firstName,familyName,IDnumber2,27560000+employeeID,gender);
        //scheck = ushort.MaxValue;
        //Console.WriteLine(scheck);
    }
}

