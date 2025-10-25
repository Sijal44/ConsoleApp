using System;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

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

     
        public string GetSummary()// returnerar en kort sammanfattning av ansökan.
        {
           return $"{CompanyName} - {PositionTitle}, {Status}, {SalaryExpectation}";
        }
    }
}
