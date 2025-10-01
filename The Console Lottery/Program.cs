namespace The_Console_Lottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("test");
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
