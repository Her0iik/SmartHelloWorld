using System;

namespace App
{
    class Program
    {

        public static DateTime getDateTime (){
            return DateTime.Now;
        }
        
        static void Main(string[] args)
        {
            IOutput output;
            var date = getDateTime();
            var name = args.Length > 0 ? args[0] : "World";
            var dateParsed = 0;

            if (dateParsed >= 6 && dateParsed < 12){
                output.Send($"Good morning {name}"); return;
            }
            else if (dateParsed >= 12 && dateParsed < 20)
            {
                output.Send($"Good afternood {name}"); return;
            } 
            output.Send($"Good night {name}");    
        }
    }
}
