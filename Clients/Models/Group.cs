using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Models
{
    public class Group
    {
        public Group(int id, string name, string description, string publicKey, int clientId, DateTime createdOn, DateTime lastChangeOn, int roleId, int projectId, string clientGuid, string worksapceGuid)
        {
            Id = id;
            Name = name;
            Description = description;
            PublicKey = publicKey;
            ClientId = clientId;
            CreatedOn = createdOn;
            LastChangeOn = lastChangeOn;
            RoleId = roleId;
            ProjectId = projectId;
            ClientGuid = clientGuid;
            WorksapceGuid = worksapceGuid;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PublicKey { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastChangeOn { get; set; }
        public int RoleId { get; set; }
        public int ProjectId { get; set; }
        public string ClientGuid { get; set; }
        public string WorksapceGuid { get; set; }
    }
}
