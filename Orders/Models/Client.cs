using System;
using System.Collections.Generic;
using System.Text;

namespace Groups.Models
{
    public class Client
    {
        public Client(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
    }
}
