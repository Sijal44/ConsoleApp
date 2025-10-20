namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JobManager manager=new JobManager();
            bool run = true;

            while (run)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("===Job Application Tracker ====");
                Console.WriteLine("===============================");
                Console.WriteLine("1. Lägg till ny ansökan");
                Console.WriteLine("2. Visa alla ansökningar");
                Console.WriteLine("3. Uppdatera status");
                Console.WriteLine("4. Avsluta programmet");
                Console.WriteLine("Välj ett alternativ : ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.AddJob();
                        break;
                    case "2":
                        manager.ShowAll();
                        break;
                    case "3":
                        manager.UpdateStatus();
                        break;
                    case "4":
                        run = false;
                        Console.WriteLine("Programmet avslutas...");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }

                Console.WriteLine();
            }

        }
    }
}
