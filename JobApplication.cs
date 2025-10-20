
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp
{
    public class JobApplication
    {
       //Attributer :
       public string CompanyName { get; set; }
       public string PositionTitle { get; set; }   
       public string Status { get; set; }
       public DateTime ApplicationDate { get; set; }   
       public DateTime? ResponseDate { get; set; }
       public int SalaryExpectation { get; set; }

        //======================metoder========================
        //Metoder:
        public int GetDaysSinceApplied()//den räknar antalet dagar sedan ansökan skickades.
        {
            return (DateTime.Now - ApplicationDate).Days;
        }
        //GetSummary() – returnerar en kort sammanfattning av ansökan.
        public string GetSummary()
        {
            return $"{CompanyName} - {PositionTitle}, {Status},{SalaryExpectation}";
        }
    }
}
