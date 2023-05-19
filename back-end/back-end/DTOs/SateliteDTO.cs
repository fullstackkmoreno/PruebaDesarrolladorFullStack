using Microsoft.AspNetCore.Identity;

namespace back_end.DTOs
{
    public class SateliteDTO
    {
        public string Nombre { get; set; }
        public float Distancia { get; set; }
        public string[] Mensaje { get; set; }
    }
}
