using System;
using System.Collections.Generic;

#nullable disable

namespace leave__Management.Model
{
    public partial class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? EmpId { get; set; }

        public virtual Employee Emp { get; set; }
    }
}
