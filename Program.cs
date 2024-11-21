namespace SumOfNumbers;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(0, 100);

        for(int i = 0; i < number; number--)
        {
            if(number % 5 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}
