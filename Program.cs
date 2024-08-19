using System;

namespace MzQuiz
{
    class MzQuiz
    {
        static void Main()
        {
            int[] correctAnswers =
            {
         2,2,1,2,1,1,2,3,1,1
        };
            int currentScore = 0;
            string[] Questions =
            {
            "Who was the leader of the ANC during the 2024 South African elections?",
            "What is the name of the new political party formed in December 2023, which received 14.6% of the vote in its debut election?",
            "What action did the MK Party threaten after the 2024 election results?",
            "What kind of government was proposed by Cyril Ramaphosa after the 2024 elections?",
            "Which South African infrastructure project was recently highlighted for its potential to power 80,000 homes in the Free State?",
            "What percentage of the vote did the MK Party receive in the 2024 elections?",
             "Which South African province announced a major solar energy project to help reduce power shortages?",
            "Which political party was in talks with the ANC for forming a coalition or Government of National Unity after the 2024 elections?",
            "What was the main focus of talks between the ANC and other political parties in June 2024?",
            "In which year did South Africa return to the Olympics after being banned due to apartheid?"
        };

            string[] AnswersOptions =
            {
             "a) Julius Malema\r\nb) John Steenhuisen\r\nc) Cyril Ramaphosa\r\nd) Bantu Holomisa",
            "a) EFF\r\nb) Democratic Alliance\r\nc) MK Party\r\nd) Inkatha Freedom Party",
            "a) Accept the results and form a coalition\r\nb) Boycott the first sitting of the national assembly\r\nc) Join the ruling party\r\nd) Dissolve the party",
             "a) Minority government\r\nb) Coalition government\r\nc) Government of National Unity (GNU)\r\nd) Single-party government",
            "a) Eskom Nuclear Plant\r\nb) Grootspruit Solar Plant\r\nc) Inga Hydroelectric Plant\r\nd) Medupi Coal Power Station",
            "a) 12.5%\r\nb) 10.3%\r\nc) 14.6%\r\nd) 18.9%",
             "a) Western Cape\r\nb) Gauteng\r\nc) Free State\r\nd) KwaZulu-Natal",
            "a) Democratic Alliance\r\nb) Economic Freedom Fighters\r\nc) Inkatha Freedom Party\r\nd) All of the above",
            "a) Increasing defense budget\r\nb) Forming a coalition government or Government of National Unity\r\nc) Cutting public sector wages\r\nd) Limiting foreign investments",
            "a) 1988\r\nb) 1992\r\nc) 1996\r\nd) 2000"
        };

            for (int i = 0; i < Questions.Length; i++)
            {
                bool validAnswer = false;

                while (!validAnswer)
                {
                    Console.WriteLine("Question " + (i + 1));
                    Console.WriteLine(Questions[i]);
                    Console.WriteLine(AnswersOptions[i]);
                    Console.Write("Answer is: ");
                    string userAnswers = Console.ReadLine();


                    if (string.Equals(userAnswers, "A", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 0)
                    {
                        currentScore++;
                    }
                    else if (string.Equals(userAnswers, "B", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 1)
                    {
                        currentScore++;
                    }
                    else if (string.Equals(userAnswers, "C", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 2)
                    {
                        currentScore++;
                    }
                    else if (string.Equals(userAnswers, "D", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 3)
                    {
                        currentScore++;

                    }
                    else if (string.Equals(userAnswers, "A", StringComparison.OrdinalIgnoreCase) ||
                               string.Equals(userAnswers, "B", StringComparison.OrdinalIgnoreCase) ||
                               string.Equals(userAnswers, "C", StringComparison.OrdinalIgnoreCase) ||
                               string.Equals(userAnswers, "D", StringComparison.OrdinalIgnoreCase))
                    {
                      
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please enter A, B, C, or D.");
                    }

                }
            }
            Console.WriteLine("Ypur current score is : " + currentScore + "/" + Questions.Length);
        }
    }
}
