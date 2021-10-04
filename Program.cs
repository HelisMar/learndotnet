using System;
using System.Collections.Generic;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
        
            DateTime time = new DateTime(1990, 08, 16); //lõppu saab ise sisestada kuupäeva. Alates aasta. 
                                                        // Lisada võib ka tunnid ja minutid
            Console.WriteLine(time.Date); //tänane kuupäev 
            Console.WriteLine(time.Hour);
            Console.WriteLine(time.Minute);
            Console.WriteLine(time.Second);
            Console.WriteLine(time.Millisecond);
            Console.WriteLine(time.Day); //päev
            Console.WriteLine(time.Month); 
            Console.WriteLine(time.DayOfWeek); //mis päev nädalas - ntx mis päeval sa sündinud  oled
            Console.WriteLine(time.DayOfYear); //mitmes päev aastas
            Console.WriteLine(time.Ticks);  // one ten-millionth of a second
            
            DateTime now = DateTime.Now; //Tänane kuupäev ja kellaaeg. NB! Ei saa ekr väärtust anda.
            Console.WriteLine(now);

            // time = DateTime.UnixEpoch; //annab unix timestampi alguspunkti. Ta loeb sekundeid alates 1.01.1970. 
                                        // Year 2038 problem - binary time
            
            time = DateTime.Parse("2021-12-31");
            Console.WriteLine(time);

            time = time.AddDays(3); //Lisab 3 päeva - ehk 3 päeva hiljem
            Console.WriteLine(time);
            // time= time.AddHours, AddMinutes jne on ka olemas

            Console.WriteLine(time.ToLongDateString()); // Kirjutab välja pika kuupäeva - monteerib ümber 

            Console.WriteLine(time.ToString("yyyy MMMM ddd")); //lingilt saab näha lühendeid, kuidas neid kirja panna.
                    //https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1

                    
        }
    }
}

