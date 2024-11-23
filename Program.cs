namespace SumOfNumbers;

class Program
{
    static void Main(string[] args)
    {

        int maxValue = 100;
        int minValue = 0;
        int firstDivider = 3;
        int secondDivider = 5;

        Random random = new Random();
        int number = random.Next(minValue, maxValue);

        for(int i = minValue; minValue < number; number--)
        {
            if(number % firstDivider == 0 || number % secondDivider == 0)
            {
                Console.WriteLine(number);
            }
        }

    }
}
