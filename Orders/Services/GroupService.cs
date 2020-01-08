using System;
using System.Collections.Generic;
using Groups.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Groups.Services
{
    public class GroupService : IGroupService
    {
        private IList<Group> _groups;
        public GroupService()
        {
            _groups = new List<Group>();
            _groups.Add(new Group("Processing/Underwriting Executive", "Executive", DateTime.Now, 16, "E912C001-C228-46BD-9995-F758943E23CA7"));
            _groups.Add(new Group("Post Close Survey BusinessManager", "survey business manager", DateTime.Now.AddHours(1), 16, "E912C001-C228-46BD-9995-F758943E23CA"));
            _groups.Add(new Group("Post Close Survey IAT", "post survey", DateTime.Now.AddHours(2), 16, "E912C001-C228-46BD-9995-F758943E23CA"));
            _groups.Add(new Group("Processing/Underwriting BusinessManager", "Processing", DateTime.Now.AddHours(2), 16, "E912C001-C228-46BD-9995-F758943E23CA"));
            _groups.Add(new Group("Processing/Underwriting Executive", "Executive", DateTime.Now, 27, "E912C001-C228-46BD-9995-F758943E23CA7"));
            _groups.Add(new Group("Post Close Survey BusinessManager", "survey business manager", DateTime.Now.AddHours(1), 17, "E912C001-C228-46BD-9995-F758943E23CA"));
            _groups.Add(new Group("Post Close Survey IAT", "post survey", DateTime.Now.AddHours(2), 1, "E912C001-C228-46BD-9995-F758943E23CA"));
            _groups.Add(new Group("Processing/Underwriting BusinessManager", "Processing", DateTime.Now.AddHours(2), 16, "E912C001-C228-46BD-9995-F758943E23CA"));
        }
        public Task<Group> GetGroupByIdAsync(string id)
        {
            return Task.FromResult(_groups.Single(o => Equals(o.Id, id)));
        }

        public Task<IEnumerable<Group>> GetGroupsAsync()
        {
            return Task.FromResult(_groups.AsEnumerable());//good enough for now
        }
    }

    public interface IGroupService
    {
        Task<Group> GetGroupByIdAsync(string id);
        Task<IEnumerable<Group>> GetGroupsAsync();
    }
}
