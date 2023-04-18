using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFdatabase.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
    }
}
