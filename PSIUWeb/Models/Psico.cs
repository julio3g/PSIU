using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSIUWeb.Models
{
    public class Psico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome requerido.")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Data de nascimento requerida.")]
        [Display(Name = "Data de nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Crp requerido.")]
        [Display(Name = "Crp")]
        public string? Crp { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public AppUser? User { get; set; }
    }
}
