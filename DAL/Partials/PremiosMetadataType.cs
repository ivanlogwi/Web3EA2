using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Partials
{
    public class PremiosMetadataType
    {
        [Required(ErrorMessage = "Cantidad requerida")]
        [Range(1, 50, ErrorMessage = "La cantidad de premios debe ser entre 1 y 50")]
        public int CantidadPremios { get; set; }

        [Required(ErrorMessage = "Año requerido")]
        [Range(2010, 2100, ErrorMessage = "El Año debe ser mayor a 2010")]
        public int Año { get; set; }

        [Required(ErrorMessage = "Competidor requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Competidor requerido")]
        public int idCompetidor { get; set; }


    }
}
