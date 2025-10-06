namespace The_Console_Lottery
{
    internal class Program
    {
        static int[] userTicket = new int[5];

        static int[] winningnumbers = new int[3];
        static Random winningNumber = new Random();


        static void Main(string[] args)
        {
            string? restart = "";
            do
            {
                NumberGenerator();

                int userTickets = HowManyTickets();
                UserBuysTickets(userTickets);

                foreach (int t in winningnumbers)
                {
                    Console.WriteLine("nummer: " + t);
                }
                Compare();
                Console.WriteLine("Vill du spela en omgång till? y/n");
                restart = Console.ReadLine();
                Console.Clear();
            }
            while (restart == "y");
        }









            static void NumberGenerator()
            {
                for (int spins = 0; spins <= 2; spins++)
                {
                    int resultNumber = winningNumber.Next(1, 51);
                    winningnumbers[spins] = resultNumber;

                    Console.WriteLine(resultNumber);
                }
            }



            static int HowManyTickets()
            {
                int ticket;
                Console.WriteLine("Du får nu möjligheten att köpa lotter. Hur många lotter vill du köpa?: ");
                while (!int.TryParse(Console.ReadLine(), out ticket) || ticket < 1)
                {
                    Console.WriteLine("Du måste välja minst 1 lott.");
                }

                userTicket = new int[ticket];
                return ticket;
            }

            static void UserBuysTickets(int userTickets)
            {
                int ticket;

                for (int i = 0; i < userTickets; i++)
                {
                    Console.WriteLine("Vilken lott vill du ha med lottnummer 1 - 50");
                    while (!int.TryParse(Console.ReadLine(), out ticket) || ticket < 1 || ticket > 50)
                    {
                        Console.WriteLine("Du måste välja ett lottonummer mellan 1 - 50! ");
                    }
                    userTicket[i] = ticket;
                }
            }

        static void Compare()
        {
            int count = 0;
            for (int i = 0; i < userTicket.Length; i++)
            {
                for (int j = 0; j < winningnumbers.Length; j++)
                {
                    if (userTicket[i] == winningnumbers[j])
                    {
                        count++;
                        Console.WriteLine("Rätt" + userTicket[i]);
                    }
                    
                }

            }
        }


        
    }
}
