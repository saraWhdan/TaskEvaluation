using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskEvaluation.Core.Entities.DTOs
{
    public class SolutionDTO: BaseModel
    {
        public string SolutionFile { get; set; } = null!;
        public string? Notes { get; set; }

    }
}
