using System;

namespace App
{
    class Program
    {

        public static int getDateTime (){
            return DateTime.Now.Hour;
        }
        static string getName(string[] args) {
            return args.Length > 0 ? args[0] : "Thomas";
        }
          
        static void Main(string[] args)
        {
            IOutput output;
            output = new ConsoleOutput();
            var date = getDateTime();
            var name = getName(args);

            if (date >= 6 && date < 12){
                output.Send($"Good morning {name}"); return;
            }
            else if (date >= 12 && date < 20)
            {
                output.Send($"Good afternood {name}"); return;
            }  
            else
            {
            output.Send($"Good night {name}");    
            }
           
        }
    }
}
