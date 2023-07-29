using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactController.DBContext
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Column("Nome",TypeName ="Varchar(100)")]
        public string Name { get; set; }
        [Column("Email", TypeName = "Varchar(100)")]
        public string Email { get; set; }
        [Column("Contato", TypeName = "Varchar(9)")]
        public string Contato { get; set; }
    }
}
