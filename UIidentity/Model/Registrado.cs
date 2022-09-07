using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace UIidentity.Model
{
    public class Registrado
    {
        public int IdRegistrado { get; set; }

        [Column(TypeName = "varchar(100)"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public string Nombres { get; set; }

        [Column(TypeName = "varchar(100)"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public string Apellidos { get; set; }

        [Column(TypeName = "varchar(100)"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(10)"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public string Contrasena { get; set; }
    }
}
