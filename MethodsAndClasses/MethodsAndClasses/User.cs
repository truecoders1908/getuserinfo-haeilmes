
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndClasses
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Artist { get; set; }
        public string Song { get; set; }
        public string Drink { get; set; }
        public string Food { get; set; }
        public int Age { get; set; }

        public string AnswerQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        public int AnswerQuestionWithInteger(string question)
        {
            string stringAnswer = AnswerQuestion(question);
            return int.Parse(stringAnswer);
        }

    }
}