using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvaluation.Core.Interfaces.IServices
{
    public interface ISolutionService
    {

		Task<IEnumerable<SolutionDTO>> GetSolutionsAsync();
		Task<SolutionDTO> GetSolutionAsync(int id);
		Task<SolutionDTO> CreateAsync(SolutionDTO model);
		Task UpdateAsync(SolutionDTO model);
		Task DeleteAsync(int id);


	}
}
