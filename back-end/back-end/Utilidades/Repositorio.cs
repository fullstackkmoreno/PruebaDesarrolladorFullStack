using back_end.DTOs;

namespace back_end.Utilidades
{
    public class Repositorio
    {
        private SateliteDTO[] satelitesDTO = new SateliteDTO[3];
        public SateliteDTO[] GetSateliteDTO()
        {
            try
            {
                SateliteDTO sateliteDTO = new SateliteDTO() { Nombre = "Kenobi", Distancia = 100.0f, Mensaje = new string[5] { "este", "", "", "mensaje", "" } };
                satelitesDTO[0] = sateliteDTO;
                sateliteDTO = new SateliteDTO() { Nombre = "Skywalker", Distancia = 115.5f, Mensaje = new string[5] { "", "es", "", "", "secreto" } }; ;
                satelitesDTO[1] = sateliteDTO;
                sateliteDTO = new SateliteDTO() { Nombre = "Sato", Distancia = 142.7f, Mensaje = new string[5] { "este", "", "un", "", "" } }; ;
                satelitesDTO[2] = sateliteDTO;
                return satelitesDTO;
            }
            catch (Exception ex)
            {
                throw new Exception("Utilidades.Utilidad.GetSateliteDTO Mensaje: " + ex.Message);
            }
        }

        public bool SetSateliteDTO(SateliteDTO sateliteDTO)
        {
            try
            {
                if (sateliteDTO.Nombre == "Kenobi")
                {
                    satelitesDTO[0] = sateliteDTO;
                }
                else if (sateliteDTO.Nombre == "Skywalker")
                {
                    satelitesDTO[1] = sateliteDTO;
                }
                else if (sateliteDTO.Nombre == "Sato")
                {
                    satelitesDTO[2] = sateliteDTO;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
