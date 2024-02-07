using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TypesOfLoadingEFCore.Web.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public required string DepartmentName { get; set; }
        public string? DepartmentDescription { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
