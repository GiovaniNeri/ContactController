using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ContactController.DBContext
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Column("Nome",TypeName ="Varchar(100)"), AllowNull]
        public string Name { get; set; }
        [Column("Email", TypeName = "Varchar(100)"), AllowNull]
        public string Email { get; set; }
        [Column("Contato", TypeName = "Varchar(9)"), AllowNull]
        public string Contato { get; set; }
    }
}
