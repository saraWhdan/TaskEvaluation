using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvaluation.Core.Interfaces.IServices
{
    public interface IGroupService
    {
		Task<IEnumerable<GroupDTO>> GetGroupsAsync();
		Task<GroupDTO> GetGroupAsync(int id);
		Task<GroupDTO> CreateAsync(GroupDTO model);
		Task UpdateAsync(GroupDTO model);
		Task DeleteAsync(int id);
	}
}
