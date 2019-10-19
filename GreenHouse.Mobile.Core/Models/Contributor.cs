using System;
using GreenHouse.Mobile.Core.Tools;

namespace GreenHouse.Mobile.Core.Models
{
    public class Contributor : IIdentifier
    {
        public Guid Id { get; set; }
        public Guid ReportId { get; set; } 

        public Guid UserId { get; set; } 
        
        public DateTime LastUpdated { get; set; }
        
        public Report Report { get; set; }
    }
}