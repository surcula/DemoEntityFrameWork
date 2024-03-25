using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFrameWork.Entities
{
    [Table("TablePerson")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Column("FIRST_NAME")]
        public string FirstName { get; set; }
        [Column("LAST_NAME")]
        public string LastName { get; set; }
        [StringLength(50)]
        [Column("PSEUDO")]
        public string Pseudo { get; set; }
        [StringLength(150)]
        [Required]
        [Column("EMAIL")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
