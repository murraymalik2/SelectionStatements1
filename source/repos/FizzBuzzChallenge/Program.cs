using System;
using System.Security.Cryptography.X509Certificates;

namespace FizzBuzzChallenge
//Write a public method that accepts a number 
//1. access modifier
//2. return type
//3. Method Name
//4. Parameters
//5. Scope

{
    public class Program
    {
        public string FizzBuzz(int number)
        {
            var answer = "";

            //when the number is divisible by 3 return the word fizz
            if (number % 3 == 0) 
            {
                return ($"Fizz");
            }
            //when the number is divisible by 5 return the word buzz
            if (number % 5 == 0)
            {
                return ($"");
            }


            //when the number is divisible by both, return the word fizzbuzz
        }

    }
}
