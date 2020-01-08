using System;
using System.Collections.Generic;
using Identity.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Services
{
    public class GroupService : IGroupService
    {
        private IList<Group> _groups;
        public GroupService()
        {
            _groups = new List<Group>();
            //todo: add static data here
            _groups.Add(new Group(103, "Group 1", "this is g1", "213430930", 1, DateTime.Now, DateTime.Now, 1, 54, "521","39393939"));
        }

        public Task<IEnumerable<Group>> GetGroupsAsync()
        {
            return Task.FromResult(_groups.AsEnumerable());//not really async..
        }

        public Task<Group> GetGroupByIdAsync(string id)
        {
            return Task.FromResult(_groups.Single(o => Equals(o.Id, id)));
        }
    }
    public interface IGroupService
    {
        Task<Group> GetGroupByIdAsync(string id);
        Task<IEnumerable<Group>> GetGroupsAsync();
    }
}
