using System;

namespace Lab03_Review
{
    public class Program
    {
        public static void Main()
        {
            CodeChallenge1();
            CodeChallenge2();
            CodeChallenge3();
            CodeChallenge4();
        }
        public static void CodeChallenge1()
        {
            Console.WriteLine("Please enter 3 numbers. Seperate each entry with a space");
            string ? userInput = Console.ReadLine();
            int product = CalculatedProduct(userInput);

            Console.WriteLine($"The product of these 3 numbers is: {product}");
        }

        public static int CalculatedProduct(string userInput)
          
        {
            string[] inputArray = userInput.Split(" ");

            if (inputArray.Length < 3)
            {
                Console.WriteLine("0");
                return 0;
            }

            int product = 1;
            int numbers = 0;

            for (int i = 0; i < 3; i++)
            {
                if (int.TryParse(inputArray[i], out int value))
                {
                    product *= value;
                    numbers++;
                }
                else
                {
                    product *= 1; 
                }

            }

            return product;
        }

        public static void CodeChallenge2()
        {
            int number;
            bool isValidInput = false;

            do
            {
                Console.WriteLine("Please enter a number between 2-10: ");

                if (int.TryParse(Console.ReadLine(), out number) && number >= 2 && number <= 10)
                {
                    isValidInput = true;
                }
                else 
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            } while (!isValidInput);

            int sum = 0;
            int validInputs = 0;

            for (int i =1; i <= number; i++)
            {
                Console.Write($"{i} of {number} - Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out int toBeAvgd) && toBeAvgd >= 0)
                {
                    sum += toBeAvgd;
                    validInputs++;

                }
                else
                {
                    Console.WriteLine("Invalid number. Skipping this input.");
                }
            }

            double average = validInputs > 0 ? (double)sum / validInputs : 0;

            Console.WriteLine($"The average of these {validInputs} numbers is: {average}");


        }

        public static void CodeChallenge3() 
        {
            Console.WriteLine("        *");
            Console.WriteLine("       ***");
            Console.WriteLine("      *****");
            Console.WriteLine("     *******");
            Console.WriteLine("    *********");
            Console.WriteLine("     *******");
            Console.WriteLine("      *****");
            Console.WriteLine("       ***");
            Console.WriteLine("        *");
        }

        public static void CodeChallenge4()
        {
            Console.WriteLine("Please enter an array of numbers. Seperate each entry with a space");
            string ? inputNumbers = Console.ReadLine();

            int[] numbers = toArray(inputNumbers);
            int mostFrequent = mostFrequentNumber(numbers);

            Console.WriteLine($"The most frequent number is: {mostFrequent}");
        }

        public static int[] toArray(string inputNumbers) 
        {
            string[] inputArray = inputNumbers.Split(" ");

            int[] numbers = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                int.TryParse(inputArray[i], out numbers[i]);
            }

            return numbers;
        }

        private class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int value)
            {
                Value = value;
            }
        }

        public static int mostFrequentNumber (int[] numbers)
        {
            if (numbers.Length < 2)
            {
                return numbers [0];
            }

            LinkedList<int> numberList = new LinkedList<int>();

            foreach (int number in numbers)
            {
                LinkedListNode<int> node = numberList.Find(number);

                if (node != null)
                {
                    numberList.Remove(node);
                    node.Value++;
                }
                else
                {
                    numberList.AddLast(new LinkedListNode<int>(number));
                }
            }

            int mostFrequent = 0;
            LinkedListNode<int> mostFrequentNode = null;

            foreach (LinkedListNode<int> node in numberList)
            {
                if (node.Value > mostFrequent)
                {
                    mostFrequent = node.Value;
                    mostFrequentNode = node;
                }
            }

            return mostFrequentNode.Value;
        }
    }
}