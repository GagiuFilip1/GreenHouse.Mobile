using System;
using GreenHouse.Mobile.Core.Tools;

namespace GreenHouse.Mobile.Core.Models
{
    public class UserFriend : IIdentifier
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid FriendId { get; set; }
        public Account User { get; set; }
    }
}