using System;
using GreenHouse.Mobile.Core.Tools;

namespace GreenHouse.Mobile.Core.Models
{
    public class Schedule : IIdentifier
    {
        public Guid Id { get; set; }
        
        public Guid ReportId { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime FinishDate { get; set; }
        public Report Report { get; set; }
    }
}