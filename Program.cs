using System;
using System.Collections.Generic;

namespace _107Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.Variables();
            p.TestCollections();

            int result = p.SumOfNumbers(21,21);
            System.Console.WriteLine(result); // the answer to life the universe and everything that

            int greatest = p.GreatestNumber(123, 1987612, 98723);
            System.Console.WriteLine(greatest);
        }

        /*
        access levles:
            public
            private
            protected
            default (empty)
        */
        
        // HOMEWORK //
        int GreatestNumber(int n1, int n2, int n3)
        {
            if(n1 > n2 && n1 > n3)
            {
                return n1;
            }
            else if(n2 > n1 && n2 > n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }

        }

        public int SumOfNumbers(int num1, int num2)
        {
            int res = num1 + num2;
            return res;
        }

        // access_level  return_type   method_name (params)
        public int Variables()
        {
            // strong typed
            string name = "Matt";
            int age = 42;
            float distance = 3445.423f;
            decimal price = 29.99m;
            bool found = false;



            // conditional blocks
            if(age < 100)
            {
                Console.WriteLine("Don't worry, you are still young");
                // cw press tab or enter will write Console.WriteLine
                Console.WriteLine("jsfkshfksdhf");
            }
            else
            {
                System.Console.WriteLine("Ouch, you are getting old");
            }

            // loops
            for(int i=0; i< 10; i++)
            {
                System.Console.WriteLine(i + "iteration");
            }
        

            return 1;
        }  // end of Variables

        public void TestCollections()
        {
            // arrays
            string[] names = new string[1000];
            names[0] = "Nick";
            names [1] = "Jay";
            names[3] = "Eric";







            // lists
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Dark Yellow");
            colors.Add("blue");
            colors.Add("purple");
            colors.Add("black");

            System.Console.WriteLine(colors);

            for(int i=0; i<colors.Count; i++)
            {
                string color = colors[i];
                System.Console.WriteLine(color);
            }

            foreach(string color in colors)
            {
                System.Console.WriteLine(color);
            }

        }

    }
}



// JS = pascalCase
// CS CamelCase


// Interpreted 

