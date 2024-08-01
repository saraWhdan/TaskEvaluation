using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TaskEvaluation.Core.Entities.DTOs
{
    public class CourseDTO: BaseModel
    {
        public string Title { get; set; } = null!;
        public bool IsCompleted { get; set; }
    }
}
