using System;


namespace varExercise
{
    class Program
    {
       

        static void Main(string[] args)
        {
            // variable declarations
            string name;
            int age;

            
            bool isCoding;
            double age2;
            decimal age3;

            // variable initializations
            age = 19;
            name = "Katelyn";
            age2 = 38;
            age3 = 19;


            isCoding = true;


            Console.WriteLine($"{name} is {age}. Is she coding?: {isCoding}");
            Console.WriteLine($"{name} will be {age2} in 19 years");
            Console.WriteLine($"{age2} - {age} is {age3}");
        }



    }

}

