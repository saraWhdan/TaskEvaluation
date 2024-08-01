namespace TaskEvaluation.Core.Interfaces.IServices
{
	public interface IAssignmentService
    {
		Task<IEnumerable<AssignmentDTO>> GetAssignmentsAsync();
		Task<AssignmentDTO> GetAssignmentAsync(int id);
		Task<AssignmentDTO> CreateAsync(AssignmentDTO model);
		Task UpdateAsync(AssignmentDTO model);
		Task DeleteAsync(int id);
	}
}
