namespace back_end.Entidades
{
    using back_end.Validaciones;
    using System.ComponentModel.DataAnnotations;

    public class Genero
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50)]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }

    }
}
