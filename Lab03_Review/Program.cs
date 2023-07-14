namespace Lab03_Review
{
    public class Program
    {
        public static void Main()
        {
            CodeChallenge1();
            CodeChallenge2();
        }
        public static int CodeChallenge1()
        {
            Console.WriteLine("Please enter 3 numbers. Seperate each entry with a space");
            string ? userInput = Console.ReadLine();
            string[] inputArray = userInput.Split(" ");

            if (inputArray.Length < 3)
            {
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

            Console.WriteLine($"The product of these {numbers} numbers is: {product}");
            return product;
        }

        public static int CodeChallenge2()
        { 
        }
    }
}