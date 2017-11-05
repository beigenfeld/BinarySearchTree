using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        Random random = new Random();
        private Node head;
        private Node current;
        private int numberOfGuesses = 0;
        string userInput;
        int guess;
        int numberToGuess;
        bool dataIsEqual;
        bool dataIsLarger;

        //Member Methods

        public Node AddHeadNode()
        {
            Node head = new Node();
            head.data = numberToGuess;
            head.left = null;
            head.right = null;
            current = head;
            return head;
        }
        
        private void Guess()
        {
            Console.WriteLine("Guess a number between 1 and 100:");
            userInput = Console.ReadLine();
            guess = Convert.ToInt16(userInput);
            if(guess < 1 || guess> 100)
            {
                Console.WriteLine("Out of range, guess again");
            }
        }

        private void ImThinkingOfANumber()
        {
            numberToGuess = random.Next(1, 101);
        }

        public void Compare()
        {
            IsDataEqual();
            if (dataIsEqual)
            {
                numberOfGuesses++;
                Console.WriteLine("You have matched the number " + numberToGuess + " in " + numberOfGuesses + " guesses");
            }
            dataIsLarger = IsDataLarger(guess);
        }

        public void AddNode()
        {
            if (dataIsLarger)
            {
                Node current = head;
                if (current.right != null)
                {
                    current = current.right;
                    IsDataLarger(current.data);
                }
                else
                {
                    Node toAdd = new Node();
                    toAdd.data = guess;
                    current.right = toAdd;
                    toAdd.left = null;
                    toAdd.right = null;
                    numberOfGuesses++;
                }
                Console.WriteLine("Your guess is Larger than the number I'm thinking of.");


            }
            else
            {
                    

                current = head;
                if (current.left != null)
                {
                    current = current.left;
                    IsDataLarger(current.data);
                }
                else
                {
                    Node toAdd = new Node();
                    toAdd.data = guess;
                    current.left = toAdd;
                    toAdd.left = null;
                    toAdd.right = null;
                    numberOfGuesses++;
                }
                Console.WriteLine("Your guess is Smaller than the number I'm thinking of.");
            }
        }


        private void SearchTree()
        {

        }


        
        private bool IsDataLarger(int guess)
        {
            if (guess > current.data)
            {
                dataIsLarger = true;
            }
            else if(guess < current.data)
            {
                dataIsLarger = false;
            }
            return dataIsLarger;
        }


        private bool IsDataEqual()

        {
            if (numberToGuess == guess)
            {
                dataIsEqual = true;
            }
            else
            {
                dataIsEqual = false;
            }
            return dataIsEqual;
        }

        public void RunGame()
        {
            ImThinkingOfANumber();
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("Take a guess, I'll tell you if the number is Larger, Smaller, or if you guessed it right!");
            head = AddHeadNode();
            Console.WriteLine(numberToGuess);
            while (numberToGuess != guess)
            {
                Guess();
                Compare();
                AddNode();
            }
        }

        //private void Compare()
        //{
        //    Node current = head;
        //    if (guess == numberToGuess)
        //    {
        //        numberOfGuesses++;
        //        Console.WriteLine("You guessed right!");
        //        return;
        //    }
        //    else if (guess > numberToGuess)
        //    {
        //        current = current.right;
        //        if (current.data == null)
        //        {
        //            current.data = guess;
        //            numberOfGuesses++;
        //        }
        //        else
        //        {
        //            Compare();
        //        }
        //    }
        //    else if (guess < numberToGuess)
        //    {
        //        current = current.left;
        //        if (current.data == null)
        //        {
        //            current.data = guess;
        //            numberOfGuesses++;
        //        }
        //        else
        //        {
        //            Compare();
        //        }
        //    }
        //}








    }
}
