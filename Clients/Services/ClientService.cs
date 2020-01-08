using System;
using System.Collections.Generic;
using Identity.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Services 
{
    public class ClientService : IClientService
    {
        private IList<Client> _clients;
        public ClientService()
        {
            _clients = new List<Client>();
            //todo: add static data here
            _clients.Add(new Client(1,"Mark Tiahrt","23432233","MyFilePath", DateTime.Now, DateTime.Now));
        }
        public Task<IEnumerable<Client>> GetClientsAsync()
        {
            return Task.FromResult(_clients.AsEnumerable());//not really async though
        }

        public Task<Client> GetClientsByIdAsync(string id)
        {
            return Task.FromResult(_clients.Single(o => Equals(o.Id, id)));
        }
    }

    public interface IClientService
{
    Task<Client> GetClientsByIdAsync(string id);
    Task<IEnumerable<Client>> GetClientsAsync();
}
}
