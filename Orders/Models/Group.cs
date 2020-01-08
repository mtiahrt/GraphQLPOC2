using System;

namespace Groups.Models
{
    public class Group
    {
        public Group(string name, string discription, DateTime created, int clientId, string clientGuid)
        {
            Name = name;
            Discription = discription;
            CreatedOn = created;
            ClientId = clientId;
            Id = clientGuid;
            Status = GroupStatuses.CREATED;
        }

        public string Name { get; set; }
        public string Discription { get; set; }
        public DateTime CreatedOn { get; private set; }
        public int ClientId { get; set; }
        public string Id { get; private set; }
        public GroupStatuses Status { get; set; }
        [Flags]
        public enum GroupStatuses
        {
            CREATED = 2,
            PROCESSING = 4,
            COMPLETED = 8,
            CANCELLED = 16,
            CLOSED = 32
        }
    }
}
