using back_end.DTOs;
using back_end.Utilidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net.NetworkInformation;

namespace back_end.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseEspacialController : Controller
    {
        private readonly ILogger<BaseEspacialController> _loggerBaseEspacial;
        public BaseEspacialController(ILogger<BaseEspacialController> baseEspacialLogger)
        {
            _loggerBaseEspacial = baseEspacialLogger;
        }


        [HttpGet("{satelite_name}")]
        public async Task<ActionResult<EmisorDTO>> Get(string satelite_name)
        {
            try
            {
                var resultado = new EmisorDTO();
                var resultadoaux = new EmisorDTO();
                var utilidad = new Utilidad();
                var repositorio = new Repositorio();
                SateliteDTO[] satelitesDTO = repositorio.GetSateliteDTO();

                string[] mensaje1 = new string[5];
                string[] mensaje2 = new string[5];
                string[] mensaje3 = new string[5];
                mensaje1[0] = string.Empty;
                mensaje1[1] = string.Empty;
                mensaje1[2] = string.Empty;
                mensaje1[3] = string.Empty;
                mensaje1[4] = string.Empty;
                mensaje2[0] = string.Empty;
                mensaje2[1] = string.Empty;
                mensaje2[2] = string.Empty;
                mensaje2[3] = string.Empty;
                mensaje2[4] = string.Empty;
                mensaje3[0] = string.Empty;
                mensaje3[1] = string.Empty;
                mensaje3[2] = string.Empty;
                mensaje3[3] = string.Empty;
                mensaje3[4] = string.Empty;
                float distancia1 = 0;
                float distancia2 = 0;
                float distancia3 = 0;

                //obtener mensaje
                //obtener x, y
                if (satelite_name == "Kenobi")
                {
                    mensaje1 = satelitesDTO.ToList().ElementAt(0).Mensaje;
                    distancia1 = satelitesDTO.ToList().ElementAt(0).Distancia;
                }
                else if (satelite_name == "Skywalker")
                {
                    mensaje2 = satelitesDTO.ToList().ElementAt(1).Mensaje;
                    distancia2 = satelitesDTO.ToList().ElementAt(1).Distancia;
                }
                else if (satelite_name == "Sato")
                {
                    mensaje3 = satelitesDTO.ToList().ElementAt(2).Mensaje;
                    distancia3 = satelitesDTO.ToList().ElementAt(2).Distancia;
                }

                resultadoaux = utilidad.GetMessage(mensaje1, mensaje2, mensaje3);
                resultado.Mensaje = resultadoaux.Mensaje;

                resultadoaux = utilidad.GetLocation(distancia1, distancia2, distancia3);
                resultado.X = resultadoaux.X;
                resultado.Y = resultadoaux.Y;

                if (resultado.Mensaje == null && resultado.X == null && resultado.Y == null)
                {
                    return NotFound();
                }
                return resultado;
            }catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<EmisorDTO>> Post([FromBody] SateliteDTO[] satelitesDTO)
        {
            try
            {
                var resultado = new EmisorDTO();
                var resultadoaux = new EmisorDTO();
                var utilidad = new Utilidad();
                string[] mensaje1 = new string[5];
                string[] mensaje2 = new string[5];
                string[] mensaje3 = new string[5];
                float distancia1 = 0;
                float distancia2 = 0;
                float distancia3 = 0;

                //obtener mensaje
                mensaje1 = satelitesDTO.ToList().ElementAt(0).Mensaje;
                mensaje2 = satelitesDTO.ToList().ElementAt(1).Mensaje;
                mensaje3 = satelitesDTO.ToList().ElementAt(2).Mensaje;

                resultadoaux = utilidad.GetMessage(mensaje1, mensaje2, mensaje3);
                resultado.Mensaje = resultadoaux.Mensaje;

                //obtener x, y
                distancia1 = satelitesDTO.ToList().ElementAt(0).Distancia;
                distancia2 = satelitesDTO.ToList().ElementAt(1).Distancia;
                distancia3 = satelitesDTO.ToList().ElementAt(2).Distancia;

                resultadoaux = utilidad.GetLocation(distancia1, distancia2, distancia3);
                resultado.X = resultadoaux.X;
                resultado.Y = resultadoaux.Y;

                if (resultado.Mensaje == null && resultado.X == null && resultado.Y == null)
                {
                    return NotFound();
                }
                return resultado;
            }catch(Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPost("{satelite_name}")]
        public async Task<ActionResult> Post(string satelite_name, [FromBody] SateliteDTO sateliteDTO)
        {
            try
            {
                var repositorio = new Repositorio();
                repositorio.SetSateliteDTO(sateliteDTO);    
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }


    }
}
