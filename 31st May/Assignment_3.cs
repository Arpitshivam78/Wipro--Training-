/* 
 3. Quiz Application (OOP + Collections)
 Concepts: Class design, Dictionary, Random, User input Task:
 Create a class Question with text, options, correct answer
 Store questions in a list
 Display random questions and score the user's answers
*/  

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        list<Question> questions = new List<Question>
        {
            new Question("What is the capital of France?", new string[] { "Paris", "London", "Berlin", "Rome" }, "Paris"),
            new Question("What is the largest planet in our solar system?", new string[] { "Mars", "Jupiter", "Saturn", "Neptune" }, "Jupiter"),
            new Question("What is the smallest planet in our solar system?", new string[] { "Mercury", "Venus", "Earth", "Mars" }, "Mercury"),
            new Question("National Animal of India ?", new string[] { "Tiger", "Liger", "Elephant", "Bear"})
        };

        Random random = new Random();

        int score = 0;

        for (int i = 0; i < questions.Count; i++)
        { 
            Question question = questions[i];
            Console.WriteLine(question.Text);

            for (int j = 0; j < question.Options.Length; j++)
            {
                string option = question.Options[j];
                Console.WriteLine($"{j + 1}. {option}"); 
                
            } 

            int userAnswer = int.Parse(Console.ReadLine());
            if (userAnswer == question.CorrectAnswer)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }   
    }
}