using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Partials
{
    public class CompetidorMetadataType
    {
        [Required(ErrorMessage = "Nombre requerido")]
        [StringLength(100, ErrorMessage = "El Nombre no debe ser mayor a 100")]
        public string Nombre { get; set; }

    }
}
