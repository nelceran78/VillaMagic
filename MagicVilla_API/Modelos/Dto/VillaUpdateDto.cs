using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelos.Dto
{
    public class VillaUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="El Nombre es Requerido")]
        [MaxLength(30)]
        public string Nombre { get; set; }

        public string Detalle { get; set; }

        [Required(ErrorMessage = "La Tarifa es Requerida")]
        public double Tarifa { get; set; }

        [Required(ErrorMessage = "Cantidad Ocupantes es Requerido")]
        public int Ocupantes { get; set; }

        [Required(ErrorMessage = "Los Metros Cuadrados son Requeridos")]
        public int MetrosCuadrados { get; set; }

        [Required(ErrorMessage = "La URL de la imagen es Requerida")]
        public string ImagenUrl { get; set; }

        public string Amenidad { get; set; }
    }
}
