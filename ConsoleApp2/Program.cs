using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine($"Before swap a is {a} and b is {b}");
            swap(a, b);
            Console.WriteLine($"After swap a is {a} and b is {b}");
            quiz obj = new quiz();
            obj.test();
        }
        public static void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After swap a is {a} and b is {b}");
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Blue;

        }
        public class quiz
        {
            string[] questions = {
            "What is the capital of France?",
            "Who wrote 'Romeo and Juliet'?",
            "What is the chemical symbol for water?"
        };
            string[] answers = { "Paris", "William Shakespeare", "H2O" };
            
            // Initialize score
            int score = 0;
            public void test()
            {
                for(int i=0; i<=questions.Length; i++)
                {
                    bool correctanser = false;
                    while (!correctanser)
                    {

                        Console.WriteLine(questions[i]);
                        Console.WriteLine("You answer is ");
                        string ans = Console.ReadLine();
                        if (ans.ToLower() == answers[i+1].ToLower())
                        {
                           
                            score++;
                            Console.WriteLine("Correct \n ");
                            correctanser = true;
                        }
                        else
                        {
                            Console.WriteLine("Flase");
                        }













                    }
                }
            }


        }

    }
}
