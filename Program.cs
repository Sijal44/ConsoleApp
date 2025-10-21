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
                Console.WriteLine("    Job Application Tracker    ");
                Console.WriteLine("===============================");
                Console.WriteLine("1. Lägg till ny ansökan");
                Console.WriteLine("2. Ta bort ansökan");
                Console.WriteLine("3. Visa alla ansökningar");
                Console.WriteLine("4. Uppdatera status");
                Console.WriteLine("5. Avsluta programmet");
                Console.WriteLine();
                Console.Write("Välj ett alternativ: ");

                string choice = Console.ReadLine();
                Console.Clear();


                switch (choice)
                {
                    case "1":
                        manager.AddJob();
                        break;
                    case "2":
                        manager.DeleteJob();
                        break;
                    case "3":
                        manager.ShowAll();
                        break;
                    case "4":
                        manager.UpdateStatus();
                        break;
                    case "5":
                        run = false;
                        Console.WriteLine("Programmet avslutas...");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }
    }
}
