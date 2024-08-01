using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvaluation.Core.Interfaces.IServices
{
    public interface ICourseService
    {
		Task<IEnumerable<CourseDTO>> GetCoursesAsync();
		Task<CourseDTO> GetCourseAsync(int id);
		Task<CourseDTO> CreateAsync(CourseDTO model);
		Task UpdateAsync(CourseDTO model);
		Task DeleteAsync(int id);
	}
}
