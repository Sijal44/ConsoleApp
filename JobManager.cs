namespace ConsoleApp
{
    public class JobManager
    {
        //Attributer :
        //Applications Samling av alla ansökningar
        List<JobApplication> Applications = new List<JobApplication>();

        //======================metoder========================

       //AddJob() – lägger till en ny ansökan
        public void AddJob()
        {
            JobApplication newJob = new JobApplication();
            Console.WriteLine("Ange företagsnamn:");
            newJob.CompanyName = Console.ReadLine();

            Console.WriteLine("Ange titel:");
            newJob.PositionTitle = Console.ReadLine();

            Console.Write("Status (Applied, Interview, Offer, Rejected): ");
            newJob.Status = Console.ReadLine();

            Console.WriteLine("Ange ansökningsdatum (YYYY-MM-DD):");
            newJob.ApplicationDate = DateTime.Now; //aktuellt datum och tid just nu

            Console.WriteLine("Ange löneförväntning: (i kronor)");
            newJob.SalaryExpectation=Convert.ToInt32(Console.ReadLine());

            Applications.Add(newJob); //sparar hela objektet med all info i listan
            Console.WriteLine("Ansökan tillagd!");
        }

        //UpdateStatus() – ändrar status på en befintlig ansökan
        //ShowAll() – visar alla ansökningar
    }
}
