using System;
using System.Collections.Generic;
using GreenHouse.Mobile.Core.Enums;
using GreenHouse.Mobile.Core.Tools;

namespace GreenHouse.Mobile.Core.Models
{
    public class Report : IIdentifier
    {
        public Guid Id { get; set; }
        
        public Guid UserId { get; set; }

        public DateTime ReportedAt { get; set; }
        
        public DateTime FinishedAt { get; set; }
        
        public bool IsScheduled { get; set; }
        
        public string Description { get; set; }

        public ForestState State { get; set; }
        
        public Account Account { get; set; }
        
        public List<Contributor> Contributors { get; set; }
        
        public Schedule Schedule { get; set; }
    }
}