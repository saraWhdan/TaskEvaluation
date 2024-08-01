namespace TaskEvaluation.Infrastructure.Services
{
	public class GroupService : IGroupService
    {
		private readonly IBaseMapper<Group, GroupDTO> _groupDTOMapper;
		private readonly IBaseMapper<GroupDTO, Group> _groupMapper;
		private readonly IBaseRepository<Group> _groupRepository;

		public GroupService(
			IBaseMapper<Group, GroupDTO> groupDTOMapper,
			IBaseMapper<GroupDTO, Group> groupMapper,
			IBaseRepository<Group> groupRepository)
		{
			_groupDTOMapper = groupDTOMapper;
			_groupMapper = groupMapper;
			_groupRepository = groupRepository;
		}

		public async Task<GroupDTO> CreateAsync(GroupDTO model)
		{
			var entity = _groupMapper.MapModel(model);
			entity.EntryDate = DateTime.Now;
			return _groupDTOMapper.MapModel(await _groupRepository.Create(entity));
		}

		public async Task DeleteAsync(int id)
		{
			var entity = await _groupRepository.GetById(id);
			await _groupRepository.Delete(entity);
		}

		public async Task<GroupDTO> GetGroupAsync(int id) => _groupDTOMapper.MapModel(await _groupRepository.GetById(id));

		public async Task<IEnumerable<GroupDTO>> GetGroupsAsync() => _groupDTOMapper.MapList(await _groupRepository.GetAll());

		public async Task UpdateAsync(GroupDTO model)
		{
			var existingData = _groupMapper.MapModel(model);
			existingData.UpdateDate = DateTime.Now;
			await _groupRepository.Update(existingData);
		}
	}
}
