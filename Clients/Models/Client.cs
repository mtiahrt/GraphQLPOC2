using System;

namespace Identity.Models
{
    public class Client
    {
        public Client(int id, string name, string publicKey, string fileSharePath, DateTime createdOn, DateTime lastUpdatedOn)
        {
            Id = id;
            Name = name;
            PublicKey = publicKey;
            FileSharePath = fileSharePath;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
        }

        public int Id { get; set;}
        public string Name { get; set; }
        public string PublicKey { get; set; }
        public string FileSharePath { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
