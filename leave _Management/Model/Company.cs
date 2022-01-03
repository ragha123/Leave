using System.Collections.Generic;

namespace leave__Management.Model
{
    public partial class Company
    {
        public Company()
        {
            Employees = new HashSet<Employee>();
        }

        public int CompanyId { get; set; }
        public string Companyname { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
