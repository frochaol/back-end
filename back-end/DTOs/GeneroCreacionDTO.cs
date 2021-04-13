namespace back_end.DTOs
{
    using back_end.Validaciones;
    using System.ComponentModel.DataAnnotations;

    public class GeneroCreacionDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50)]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
    }
}
