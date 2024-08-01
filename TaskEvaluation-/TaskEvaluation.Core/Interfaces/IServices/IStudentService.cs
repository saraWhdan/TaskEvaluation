using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace TaskEvaluation.Core.Interfaces.IServices
{
    public interface IStudentService
    {
		Task<IEnumerable<StudentDTO>> GetStudentsAsync();
		Task<StudentDTO> GetStudentAsync(int id);
		Task<StudentDTO> CreateAsync(StudentDTO model);
		Task UpdateAsync(StudentDTO model);
		Task DeleteAsync(int id);

	}
}
