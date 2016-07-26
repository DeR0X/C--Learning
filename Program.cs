using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            Console.Write("I welcome u {0},\nWhere do u live: ", name);
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

            Console.WriteLine("Max int Value {0}\nMax long Value {1}\nMax decimal Value {2}\nMax float Value {3}\nMax double Value {4}\n\n\n", maxInt, maxLong, maxDecimal, maxFloat, maxDouble);
            Thread.Sleep(1500);
            //------------Some Random things------------------------
            Random rand = new Random();
            Console.WriteLine("Random Number between 1 and 10: " + (rand.Next(1, 11)));

            string sampString = "Im not empty or have whitespaces";

            Console.WriteLine("Is empty " + string.IsNullOrEmpty(sampString));
            Console.WriteLine("Is empty " + string.IsNullOrWhiteSpace(sampString));
            Console.WriteLine("String lenght " + sampString.Length);
            Console.WriteLine("Index of empty " + sampString.IndexOf("empty"));
            Console.WriteLine("3th Word " + sampString.Substring(3, 9));


            var sb2 = new StringBuilder();
            string[] names = new string[3] { "Fabian", "Kevin", "Yannick" };
            sb2.Append("League Queue List: ");
            sb2.Append(string.Join(", ", names));
            Console.WriteLine(sb2.ToString());
            Console.WriteLine("\n\n");

            Thread.Sleep(1000);
            //-----------------------formatting strings--------------------------------
            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.564,.56,1000); // confusing af
            Console.WriteLine("String Format: " + fmtStr);

            StringBuilder sb = new StringBuilder();
            sb.Append("This is the first sentence.");
            Console.WriteLine(sb.ToString());
            sb.AppendFormat("My name is {0} and i live in {1}", name, localisation);
            Console.WriteLine(sb.ToString());
            sb.Append("\n\n");

            Thread.Sleep(3000);
            //----------------Arrays--------------------------
            int[] randArray = new int[5];
            int[] randArray2 = { 1, 2, 3, 4, 5 };
            var sb1 = new StringBuilder();//Dunno what to do with this shit

            Console.WriteLine("Array Length " + randArray2.Length);
            Console.WriteLine("Items 0 " + randArray[0]);

            //i = 0; if i is smaller than randArray2.Length(5); then i++
            for (int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("{0}:{1}",i,randArray2[i]);
            }
            foreach(int num in randArray2)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Where is 1 " + Array.IndexOf(randArray2, 1));
            string[] names1 = { "Fabian", "Yannick", "Kevin" };
            sb1.Append("[");
            sb1.Append(String.Join(",", names1));
            sb1.Append("]");
            Console.WriteLine(sb1.ToString());
            


            //so the fkin window wont close everysingle time ... 
            Console.Write("\npress a fkin key to escape out of this realm");
            string endMePlease = Console.ReadLine();


        }
    }
}
