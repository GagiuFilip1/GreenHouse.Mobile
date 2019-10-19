using System;
using System.Collections.Generic;
using GreenHouse.Mobile.Core.Enums;
using GreenHouse.Mobile.Core.Tools;

namespace GreenHouse.Mobile.Core.Models
{
    public class Account : IIdentifier
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        
        public AccountType Type { get; set; }
        
        public List<Report> UserReports { get; set;}
        
        public List<UserFriend> Friends { get; set; }
    }
}