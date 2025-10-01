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

        

        static int UserBuysTickets()
        {
           
                int ticket;
            Console.WriteLine("Vilken lott vill du ha lotter med lottnummer 1 - 50");
            while(!int.TryParse(Console.ReadLine(), out ticket) || ticket < 1 || ticket > 50 )
            {
                Console.WriteLine("Du måste välja ett lottonummer mellan 1 - 50! ");
            }

            return ticket;
        }


    }
}
