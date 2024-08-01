using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.Business;
namespace TaskEvaluation.Core.Entities.DTOs
{
    public class AssignmentDTO : BaseModel
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? Deadline { get; set; }

    }
}
