using System;
using System.Globalization;

namespace Data
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Clear();
// para data atual
            // var datas = new DateTime(2020, 12, 8, 23, 23, 14);
            // var datas = DateTime.Now;
            // Console.WriteLine(datas);
            // Console.WriteLine(datas.Year);
            // Console.WriteLine(datas.Day);
            // Console.WriteLine(datas.Month);
            // Console.WriteLine(datas.Hour);
            // Console.WriteLine(datas.Minute);
            // Console.WriteLine(datas.Second);

            // Console.WriteLine((int)datas.DayOfWeek);

// formatação de data
            var datas = DateTime.Now;


            var formatada = String.Format("{0:u}", datas);
            // Console.WriteLine(formatada);

            var data = DateTime.Now;

            if(data.Date == DateTime.Now.Date){
                Console.WriteLine("é igual");

            }


            // Console.WriteLine(data);

            
            // Console.WriteLine(data.AddDays(12));

            // Console.WriteLine(data.AddMonths(1));

            // Console.WriteLine(data.AddYears(1));
            
         
//formato de data de acordo com localização CultureInfo
            var br = new CultureInfo("pt-BR");
            var pt = new CultureInfo("pt-PT");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            // Console.WriteLine(DateTime.Now.ToString("D", en));

           

            var utcTime = DateTime.UtcNow; //para aplicações globalizadas

            // Console.WriteLine(utcTime);

            // Console.WriteLine(utcTime.ToLocalTime());
            


            var timezoneAustralia = 
                TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland"); 
            
            // Console.WriteLine(timezoneAustralia);

            var horaAustralia = 
                TimeZoneInfo.ConvertTimeFromUtc(utcTime, timezoneAustralia);
            //Console.WriteLine(horaAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach(var timezone in timezones){
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcTime, timezone));
            //     Console.WriteLine("--------------------");

            // }

         

            var timeSpan = new TimeSpan();
            // Console.WriteLine(timeSpan);

            var timeSpanNanosegundo = new TimeSpan(1);
            // Console.WriteLine(timeSpanNanosegundo);

            var timeSpanMilisegundo = new TimeSpan(5, 12, 8);
            // Console.WriteLine(timeSpanMilisegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

            Console.Clear();

            Console.WriteLine(DateTime.DaysInMonth(2021, 1));
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

        }

        static bool IsWeekend(DayOfWeek today)
        {
            //retornar fim de semana
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;

        }
    }
}  
