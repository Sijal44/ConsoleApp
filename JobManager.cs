using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.IO;

namespace ConsoleApp
{
    public class JobManager
    {

        //Applications Samling av alla ansökningar
        List<JobApplication> Applications = new List<JobApplication>();

        //======================metoder========================

        public void AddJob()//AddJob() – lägger till en ny ansökan
        {
            JobApplication newJob = new JobApplication();

            Console.WriteLine("Ange företagsnamn:");
            newJob.CompanyName = Console.ReadLine();

            Console.WriteLine("Ange titel:");
            newJob.PositionTitle = Console.ReadLine();

            Console.Write("Status (Applied, Interview, Offer, Rejected): ");
            newJob.Status = Console.ReadLine();

            Console.WriteLine("Ange ansökningsdatum (YYYY-MM-DD):");
            //aktuellt datum och tid just nu
            newJob.ApplicationDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ange löneförväntning: (i kronor)");
            newJob.SalaryExpectation = Convert.ToInt32(Console.ReadLine());

            Applications.Add(newJob); //sparar hela objektet med all info i listan
            Console.WriteLine("Ansökan tillagd!");

        }
        
        public void UpdateStatus()//UpdateStatus() – ändrar status på en befintlig ansökan
        {
            Console.Write("Vilket företag vill du ändra status på? ");
            string company = Console.ReadLine();


            JobApplication job = Applications.FirstOrDefault(a => a.CompanyName == company);

            if (job == null)
            {
                Console.WriteLine("Ingen ansökan hittades med det företaget.");
                return;
            }
            Console.Write("Ange ny status (Applied, Interview, Offer, Rejected): ");
            job.Status = Console.ReadLine();
            Console.WriteLine("Status uppdaterad!");

        }
       
        public void ShowAll() //ShowAll() – visar alla ansökningar
        {
            ////Om listan är tom → visar bara ett kort meddelande
            if (Applications.Count == 0)
            {
                Console.WriteLine("Inga ansökningar finns ännu.");
                return;
            }
            foreach (var item in Applications)
            {
                Console.WriteLine(item.GetSummary()); //skriver ut en kort sammanfattning....
            }
        }
        public void DeleteJob()
        {
            Console.WriteLine("Vilket företag vill du ta bort ansökan från? ");

            ////Leta upp ansökan baserat på företagsnamnet
            var del = Applications.FirstOrDefault(a => a.CompanyName == Console.ReadLine());
            if (del != null)
            {
  
                Console.WriteLine("Ansökan borttagen.");
                // // Ta bort objektet från listan
                Applications.Remove(del);
            }
            else
            {
                Console.WriteLine("Ingen ansökan hittades med det företaget.");
            }
        }
    }
}
