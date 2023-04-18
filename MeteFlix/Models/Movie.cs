using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeteFlix.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "O Título é obrigatório")]
        [StringLength(100, ErrorMessage = "O Título deve possuir no máximo 30 caracteres")]
        public string Title { get; set; }

        [Display(Name = "Título Original")]
        [Required(ErrorMessage = "O Título é obrigatório")]
        [StringLength(100, ErrorMessage = "O Título deve possuir no máximo 30 caracteres")]
        public string TitleOriginal { get; set; }

        [Display(Name = "Sinopse")]
        [Required(ErrorMessage = "O Sinopse é obrigatório")]
        [StringLength(8000, ErrorMessage = "A Sinopse deve possuir no máximo 30 caracteres")]
        public string Synopsis { get; set; }

        [Column(TypeName = "Year")]
        [Display(Name = "Ano de Estreia")]
        [Required(ErrorMessage = "O Ano deEstreia é obriatório")]
        public int16 MovieYear { get; set; }

        [Display(Name = "Duração (em minutos)")]
        [Required(ErrorMessage = "A Duração é obrigatória")]
        public int16 Duration { get; set; }

        [Display(Name = "Classificação Etária")]
        [Required(ErrorMessage = "A Classificação Etária é obrigatória")]
        public byte Agerating { get; set; }

        [StringLength(200)]
        [Display(Name = "Foto")]
        public string Image { get; set; }

        [NotMapped]
        [Display(nameof = "Duração")]

        public string HourDuration { get {
            return TimeSpan.FromMinutes(Duration)
                .ToString(@"%h'h'mm'min'");
        } }



    }
}