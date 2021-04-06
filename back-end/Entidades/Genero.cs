using back_end.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.Entidades
{
    public class Genero: IValidatableObject
    {
        public int Id { get; set; }
        [Required]
        //[PrimeraLetraMayuscula]
        public string Nombre { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(Nombre))
            {
                var primeraLetra = Nombre[0].ToString();
                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult("La primera letra debe ser mayúscula",
                        new string[] { nameof(Nombre) });
                }
            }
        }
    }
}
