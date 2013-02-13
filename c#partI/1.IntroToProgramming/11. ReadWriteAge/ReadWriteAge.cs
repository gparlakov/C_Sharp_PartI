using System;


    class ReadWriteAge
    {
        static void Main()
        {
            Console.WriteLine("Моля напиешете годината на вашето раждане: например 1983");
            bool RealYear=false;
            int BirthYear;
            BirthYear = 0;

            while (BirthYear<1890 || BirthYear>(DateTime.Now.Year))                                  //повтаря докато годината на раждане е неприемлива 
            {
                RealYear = int.TryParse(Console.ReadLine(),out BirthYear); 
                if (BirthYear < 1890 || BirthYear > (DateTime.Now.Year) || RealYear == false)       //ако не е приемлива или празно поле отново моли за въвеждане
                {
                    Console.WriteLine("Моля въведете година между 1890 и сегашната.");
                }
            }                       
            Console.WriteLine("След десет години ще сте на {0}",(DateTime.Now.Year-BirthYear +10));   
        }
    }

