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
            string[] quizQuestions = { "What company supports .NET Core?",
                                        "What is the current version of .NET Core?",
                                        "When was .NET Core released?",
                                        "What is CoreCLR?",
                                        "What platform is compatible with .NET Core?",
                                        "What is the difference betweeen .NET Core and Mono?",
                                        "What's the difference between .NET Core, .NET Framework, and Xamarin?",
                                        ".NET Core is an ____________ framework.",
                                        "What languages can be used to write applications and libraries for .NET Core.",
                                        "Every command in .NET Core command line interface starts with _________." };

            //Declare a Multidemensional array that holds options for each questions
            string[,] quizAnswerOptions = new string[,] {
                                        {"A) VMware", "B) Microsoft", "C) Symantec", "D) Oracle" },
                                        {"A) 1.0", "B) 2.2", "C) 10.0", "D) 3.0"},
                                        {"A) 2019", "B) 2004", "C) 2014", "D) 2017"},
                                        {"A) A complete runtime implementation of the Common Language Runtime", "B) A household cleaning product", "C) The method to clear the console screen", "D) The company that runs Visual Studio"},
                                        {"A) Windows", "B) macOS", "C) Linux", "D) All of the above"},
                                        {"A) Mono is a 3rd party implementation of the .Net Framework", "B) Mono is not cross platform", "C) They are the same", "D) Mono is not open source"},
                                        {"A) All are correct", "B) .NET Framework is the 'full' or 'traditional' flavor of .NET that's distributed with Windows.", "C) .NET Core is cross-platform .NET that runs on Windows, Mac, and Linux.", "D) Xamarin is used for building mobile apps that can run on iOS, Android, or Windows Phone devices."},
                                        {"A) Licensed", "B) Obsolete", "C) Open-Sourced", "D) UI"},
                                        {"A) C#", "B) Visual Basic", "C) F#", "D) All of the above"},
                                        {"A) dotnet", "B) .net", "C) core", "D) aspdotnet"},
                                        
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
                    for (int i = 0; i < quizAnswerOptions.GetLength(1); i++){
                        Console.WriteLine(quizAnswerOptions[x, i]);

                    }
                    Console.WriteLine("Please enter an option");
                    selection = Console.ReadLine().ToUpper();
                    userSelections[x] = selection;

                    //Determine if the user's selection is the correct answers
                    if (selection == correctAnswers[x])
                    {
                        correct.Add(selection);
        
                    }
                    else
                    {
                        wrong.Add("Question: " + (x + 1) + ") " + selection);
       
                    };
                    Console.Clear();
                } // End outer For Loop

                Console.WriteLine("Press any key for your results");
                Console.ReadKey();
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
                Console.WriteLine("To take the quiz again, enter anything other than -1. To exit enter -1");
                start = Convert.ToInt32(Console.ReadLine());

            }//ENDWHILE

            Outro();

        } // End of main

  
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
