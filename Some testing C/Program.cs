using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Welcome to Spaggethi Code
 
     */


namespace Some_testing_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string name; //global value now
            string localisation; // living room
            Console.Write("Hello my Friend\nPlease tell me your Name: ");
            name = Console.ReadLine();
            Console.Write("I welcome u {0},\nWhere do u live: ",name);
            localisation = Console.ReadLine();
            Console.WriteLine("I appricate your Informations. Google wont see it\n");
            Console.WriteLine("Name: {0}\nLocalisation: {1}\n\n", name, localisation);

            //-------------Testing some stuff here--------------------
            //size of each Datatype
            float maxInt = int.MaxValue;
            float maxLong = long.MaxValue;
            decimal maxDecimal = decimal.MaxValue;
            float maxFloat = float.MaxValue;
            double maxDouble = double.MaxValue;

            Console.WriteLine("Max int Value {0}\nMax long Value {1}\nMax decimal Value {2}\nMax float Value {3}\nMax double Value {4}", maxInt, maxLong, maxDecimal, maxFloat, maxDouble);

            //------------Some Random things------------------------
            Random rand = new Random();
            Console.WriteLine("Random Number between 1 and 10: " + (rand.Next(1,11)));
      
            string sampString = "Im not empty or have whitespaces";

            Console.WriteLine("Is empty " + string.IsNullOrEmpty(sampString));
            Console.WriteLine("Is empty " + string.IsNullOrWhiteSpace(sampString));
            Console.WriteLine("String lenght " + sampString.Length);
            Console.WriteLine("Index of bunch " + sampString.IndexOf("Empty"));
            Console.WriteLine("3th Word " + sampString.Substring(3,9));

            string[] names = new string[3] { "Fabian", "Kevin", "Yannick" };
            Console.WriteLine("League Queueing List " + String.Join(", ", names));

            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.564,.56,1000); // confusing af
            Console.WriteLine("String Format: " + fmtStr);

            StringBuilder sb = new StringBuilder();
            sb.Append("This is the first sentence.");
            Console.WriteLine(sb.ToString());
            sb.AppendFormat("My name is {0} and i live in {1}", name, "Dortmund");
            Console.WriteLine(sb.ToString());
            sb.Replace("a", "e");
            Console.WriteLine(sb.ToString());
            sb.Remove(5, 7);
            Console.WriteLine(sb.ToString());

            //so the fkin window wont close everysingle time ... 
            Console.Write("press a fkin key to escape out of this realm");
            string endMePlease = Console.ReadLine();


        }
    }
}
