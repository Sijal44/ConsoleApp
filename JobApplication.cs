using System;

namespace ConsoleApp
{
    public class JobApplication
    {
       //Attributer :
       public string CompanyName { get; set; }
       public string PositionTitle { get; set; }   
       public string Status { get; set; }
       public DateTime ApplicationDate { get; set; }   
       public int SalaryExpectation { get; set; }

        //======================metoder========================
        
        //GetSummary() – returnerar en kort sammanfattning av ansökan.
        public string GetSummary()
        {
            return $"{CompanyName} - {PositionTitle}, {Status}, { SalaryExpectation},";
        }
    }
}
