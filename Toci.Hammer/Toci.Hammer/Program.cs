using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hammer
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Dictionary<string, string> monthsMap = new Dictionary<string, string>()
            {
                { "01", "styczeń" },
                { "02", "luty" },
                { "03", "marzec" },
                { "04", "kwiecień" },
                { "05", "maj" },
                { "06", "czerwiec" },
                { "07", "lipiec" },
                { "08", "sierpień" },
                { "09", "wrzesien" },
                { "10", "sierpień" },
                { "11", "listopad" },
                { "12", "grudzień" },
            };

            string Komunikat = "Witamy w toci hammer";
            Console.WriteLine(Komunikat);
            //for (;;)
            {
                string GivePeselRequest = "Podaj pesel: ";
                Console.WriteLine(GivePeselRequest);

                string peselCandidate = Console.ReadLine();

                ViewerPeselValidator validator = new ViewerPeselValidator();

                bool result = validator.IsPeselValid(peselCandidate);

                // ?? ----

                string month = peselCandidate.Substring(2, 2);

                // ?

                if (monthsMap.ContainsKey(month))
                {
                    Console.WriteLine("urodzileś się w miesiącu: " + monthsMap[month]);
                }

            }

            Console.ReadLine();
        }
    }
}
