using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class DiceRollGame
    {
        public int randomNumber { get; }

        public DiceRollGame(int sidesCount)
        {
            randomNumber = new Random().Next(1, sidesCount + 1);
        }
    }

    public class Dice
    {
        private readonly int _sidesCount = 6;
        public int Value { get; }

        public Dice()
        {
            DiceRollGame dice = new DiceRollGame(_sidesCount);
            Value = dice.randomNumber;


            Season firstSeason = Season.Summer;
            // Accessgint the enum values as 0,1,2,3
            int firstSeasonValue = (int)firstSeason;
            Console.WriteLine("Enum value : " + firstSeasonValue);
        }
    }

    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int InitialTries = 3;
        public GuessingGame(Dice dice)
        {
            _dice = dice;
            Console.WriteLine("Inside guessing game : " + _dice.Value);
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Value;
            Console.WriteLine($"Dice rolled. Guess What number it shows in {InitialTries} tries" + diceRollResult);

            var triesLeft = InitialTries;
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a Number");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                } 
                Console.WriteLine("Wrong Guess. Try Again");
                --triesLeft;
            }
            return GameResult.Loss;
        }
    }

    public static class ConsoleReader
    {
        public static int ReadInteger(string message)
        {
            int result;
            do
            {
                Console.WriteLine(message);
            }
            while (!int.TryParse(Console.ReadLine(), out result));
            return result;
        }
    }

    public enum Season
    {
        Spring, 
        Summer,
        Autumn, 
        Winter
    }

    public enum GameResult
    {
        Victory,
        Loss
    }
}

