namespace SumOfNumbers;

class Program
{
    static void Main(string[] args)
    {

        int maxValue = 100;
        int minValue = 0;

        int multiplicityChecksNumber1 = 3;
        int multiplicityChecksNumber2 = 5;


        Random random = new Random();
        int number = random.Next(minValue, maxValue);

        for(int i = 0; i < number; number--)
        {
            if(number % multiplicityChecksNumber1 == 0 || number % multiplicityChecksNumber2 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}
