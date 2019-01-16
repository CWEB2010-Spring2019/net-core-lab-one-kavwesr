using System;
using System.Collections.Generic;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args) //Start of main
        {
            //Declarations

            // Declaring an array that holds correctAnswers
            string[] correctAnswers = new string[] { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };

            // An array for end-users selection
            String[] userSelections = new string[] { };

            //Declare an array that holds the questions
            string[] quizQuestions = { "questions ....",
                                        "etc...",
                                        "etc..",
                                        "",
                                        "",
                                        "",
                                        "",
                                        "",
                                        "",
                                        "" };

            //Declare a Multidemensional array that holds options for each questions
            string[,] quizAnswerOptions = new string[,] {
                                        {"A) ", "B) ", "C) ", "D) "},
                                        {"A) ", "B) ", "C) ", "D) "},
                                        {"A) ", "B) ", "C) ", "D) "},
                                        {"A) ", "B) ", "C) ", "D) "},
                                        {"A) ", "B) ", "C) ", "D) "},
                                        {"A) ", "B) ", "C) ", "D) "},
                                        {"A) ", "B) ", "C) ", "D) "},
                                        {"A) ", "B) ", "C) ", "D) "},
                                        {"A) ", "B) ", "C) ", "D) "},
                                        {"A) ", "B) ", "C) ", "D) "},
                                        {"A) ", "B) ", "C) ", "D) "},
                                        {"A) ", "B) ", "C) ", "D) "},
            };

            string selection;
            int start;
            int EXIT = -1; // Sentinal Value

            List<string> correct = new List<string>();
            List<string> wrong = new List<string>();


            // End of Declarations 

            start = Welcome();

            while(start != EXIT){

                for(int x = 0; x < quizQuestions.Length; x++)
                {


                    Console.WriteLine(quizQuestions[x]);
                    for (int i = 0; i < quizAnswerOptions.GetLength(1); i++)
                    {
                        Console.WriteLine(quizAnswerOptions[x, i]);

                    }
                    Console.WriteLine("Please enter an options");
                    selection = Console.ReadLine().ToUpper();
                    userSelections[x] = selection;

                    //Determine if the user's selection is the correct answers
                    if (selection == correctAnswers[x])
                    {
                        correct.Add(selection);
        
                    }
                    else
                    {
                        wrong.Add(selection);
       
                    };
                    Console.WriteLine("You answered " + correct.Count + " correct out of " + quizQuestions.Length);
                    // Determine if they passed
                    var results = (correct.Count >= 7) ? "You passed the assessment" : "You didn't pass";

                    // Output the questions they got wrong.
                    if (wrong.Count > 0)
                    {
                        Console.WriteLine("These are the questions you got wrong");
                        wrong.ForEach(w => { Console.WriteLine(w); });
                    }

                    wrong.Clear();
                    correct.Clear();
                }
                Console.WriteLine("To take the quiz again, enter anything other than -1. To exit enter -1");
                start = Convert.ToInt32(Console.ReadLine());

            }//ENDWHILE
            Outro();

        } // Endo of main

  
        static int Welcome()
        {
            int start;
            Console.WriteLine("Welcome, this program will assess your knowledge of .NET Core");
            Console.WriteLine("To get started, please enter a number other than -1 to start the program");
            start = Convert.ToInt32(Console.ReadLine());
            return start;
        } // End of Welcome


        static void Outro()
        {
            Console.WriteLine("Program concluded");
            Console.WriteLine("Press Any Key to Exit");
            Console.ReadKey();
        } // End of Outro
    }
}
