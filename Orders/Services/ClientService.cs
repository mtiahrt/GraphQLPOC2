using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Groups.Models;

namespace Groups.Services
{
    //typically you'd have this in a seperate service running.
    //for the sake of a POC I put it here.  
    public class ClientService : ICustomerService
    {
        private IList<Client> _customers;
        public ClientService()
        {   
            _customers = new List<Client>();
            _customers.Add(new Client(16, "Fifth Third Bank"));
            _customers.Add(new Client(27, "ABRA"));
            _customers.Add(new Client(17, "Merrill Edge/Merrill Lynch"));
            _customers.Add(new Client(1, "Concentrix"));
        }
        public Client GetCustomerById(int id)
        {
            return GetCustomerByIdAsync(id).Result;//good for now.....  
        }

        public Task<Client> GetCustomerByIdAsync(int id)
        {
            return Task.FromResult(_customers.Single(o => Equals(o.Id, id)));
        }

        public Task<IEnumerable<Client>> GetCustomersAsync()
        {
            return Task.FromResult(_customers.AsEnumerable());
        }
    }
    public interface ICustomerService
    {
        Client GetCustomerById(int id);
        Task<Client> GetCustomerByIdAsync(int id);
        Task<IEnumerable<Client>> GetCustomersAsync();
    }
}
