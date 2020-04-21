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

            var date = getDateTime();
            var name = getName(args);

            if (date >= 6 && date < 12){
                //output.Send($"Good morning {name}"); return;
                Console.WriteLine("Good morning "+ name);
            }
            else if (date >= 12 && date < 20)
            {
                //output.Send($"Good afternood {name}"); return;
                Console.WriteLine("Good afternood "+ name);
            }  
            else
            {
            //output.Send($"Good night {name}");    
            Console.WriteLine("Good night "+ name);
            }
           
        }
    }
}
