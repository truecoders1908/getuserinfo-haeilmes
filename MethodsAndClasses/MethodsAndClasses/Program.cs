using System;
using System.Collections.Generic;

namespace MethodsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            User you = new User();
            Console.WriteLine("I want to ask you some questions. Is that cool?");
            Console.WriteLine("Even if its not, too bad.");

            you.FirstName = you.AnswerQuestion("What's your first name?");
            you.LastName = you.AnswerQuestion("What's your last name?");
            you.Artist = you.AnswerQuestion("Favorite musical artist right now?");
            you.Song = you.AnswerQuestion("What song from them do you recommend?");
            you.Food = you.AnswerQuestion("If you had to pick your top meal, what would that be?");
            you.Drink = you.AnswerQuestion("What about a drink you enjoy with that meal?");
            you.Age = you.AnswerQuestionWithInteger("Just to be safe,(and creepy) how old are you?");



            Console.WriteLine($"Howdy, {you.FirstName} {you.LastName}. You say you've been around the sun {you.Age} times.");
            Console.WriteLine($"So you've been listening to {you.Artist} and they have a great song called {you.Song}. Very cool.");
            Console.WriteLine($"As for your preference on food that would be {you.Food} paired with a nice refreshing {you.Drink}.");
            Console.WriteLine("Now that wasn't so bad, was it? Either way, you seem like you got some great taste my new friend. ");

        }
    }
}