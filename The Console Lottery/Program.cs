namespace The_Console_Lottery
{
    internal class Program
    {
        static int[] winningnumbers = new int [3];
        static void Main(string[] args)
        {
            
            
        }

        static void NumberGenerator()
        {
            Random winningNumber = new Random();

            for (int spins = 0; spins <= 2; spins++)
            {
                int resultNumber = winningNumber.Next(1, 51);
                winningnumbers[spins] = resultNumber;
                
                Console.WriteLine(resultNumber);

            }


        }
    }
}
