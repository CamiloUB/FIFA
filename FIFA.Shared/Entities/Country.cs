using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Pais")] // {0}
        [MaxLength(100, ErrorMessage = "Cuidado el campo{0} solo puede contener{1} caracteres")]
        [Required(ErrorMessage ="El campo{0} es obligatorio{1}")]
        public string? Name { get; set; }
    }
}