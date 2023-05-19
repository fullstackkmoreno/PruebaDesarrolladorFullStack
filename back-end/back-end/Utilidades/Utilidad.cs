using back_end.DTOs;
using System.Net;

namespace back_end.Utilidades
{
    public class Utilidad
    {
        private const float KenobiX = -500;
        private const float KenobiY = -200;
        private const float SkywalkerX = 100;
        private const float SkywalkerY = -100;
        private const float SatoX = 500;
        private const float SatoY = 100;
        public EmisorDTO GetLocation(float distancia1, float distancia2, float distancia3) 
        {
            try { 
                var emisor = new EmisorDTO();
                float raizdedos = (float)Math.Sqrt(2);
                float x = 0;
                emisor.X = 0;

                // triangulo rectangulo isosceles
                // para distancia1
                x = distancia1 / raizdedos;
                emisor.Y = (KenobiY * (-1)) + x;

                // para distancia2
                x = distancia2 / raizdedos;
                emisor.Y = (SkywalkerY * (-1)) + x;
                // para distancia3
                x = distancia3 / raizdedos;
                emisor.Y = SatoY + x;

                return emisor;
            }
            catch (Exception ex)
            {
                throw new Exception("Utilidades.Utilidad.GetLocation Mensaje: " + ex.Message);
            }

        }

        public EmisorDTO GetMessage(string[] mensaje1, string[] mensaje2, string[] mensaje3) 
      {
            try { 
                var emisor = new EmisorDTO();
                string palabra1 = string.Empty;
                string palabra2 = string.Empty;
                string palabra3 = string.Empty;
                string palabra4 = string.Empty;
                string palabra5 = string.Empty;
                if (mensaje1.ElementAt(0).ToString() == mensaje2.ElementAt(0).ToString())
                {
                    palabra1 = mensaje1.ElementAt(0).ToString();
                }
                if (mensaje1.ElementAt(0).ToString() == mensaje3.ElementAt(0).ToString())
                {
                    palabra1 = mensaje1.ElementAt(0).ToString();
                }
                if (mensaje2.ElementAt(0).ToString() == mensaje3.ElementAt(0).ToString())
                {
                    palabra1 = mensaje2.ElementAt(0).ToString();
                }
                if (palabra1 == string.Empty)
                    palabra1 = mensaje1.ElementAt(0).ToString() + mensaje2.ElementAt(0).ToString() + mensaje3.ElementAt(0).ToString();

                if (mensaje1.ElementAt(1).ToString() == mensaje2.ElementAt(1).ToString())
                {
                    palabra2 = mensaje1.ElementAt(1).ToString();
                }
                if (mensaje1.ElementAt(1).ToString() == mensaje3.ElementAt(1).ToString())
                {
                    palabra2 = mensaje1.ElementAt(1).ToString();
                }
                if (mensaje2.ElementAt(1).ToString() == mensaje3.ElementAt(1).ToString())
                {
                    palabra2 = mensaje2.ElementAt(1).ToString();
                }
                if (palabra2 == string.Empty)
                    palabra2 = mensaje1.ElementAt(1).ToString() + mensaje2.ElementAt(1).ToString() + mensaje3.ElementAt(1).ToString();
            
                if (mensaje1.ElementAt(2).ToString() == mensaje2.ElementAt(2).ToString())
                {
                    palabra3 = mensaje1.ElementAt(2).ToString();
                }
                if (mensaje1.ElementAt(2).ToString() == mensaje3.ElementAt(2).ToString())
                {
                    palabra3 = mensaje1.ElementAt(2).ToString();
                }
                if (mensaje2.ElementAt(2).ToString() == mensaje3.ElementAt(2).ToString())
                {
                    palabra3 = mensaje2.ElementAt(2).ToString();
                }
                if (palabra3 == string.Empty)
                    palabra3 = mensaje1.ElementAt(2).ToString() + mensaje2.ElementAt(2).ToString() + mensaje3.ElementAt(2).ToString();

                if (mensaje1.ElementAt(3).ToString() == mensaje2.ElementAt(3).ToString())
                {
                    palabra4 = mensaje1.ElementAt(3).ToString();
                }
                if (mensaje1.ElementAt(3).ToString() == mensaje3.ElementAt(3).ToString())
                {
                    palabra4 = mensaje1.ElementAt(3).ToString();
                }
                if (mensaje2.ElementAt(3).ToString() == mensaje3.ElementAt(3).ToString())
                {
                    palabra4 = mensaje2.ElementAt(3).ToString();
                }
                if (palabra4 == string.Empty)
                    palabra4 = mensaje1.ElementAt(3).ToString() + mensaje2.ElementAt(3).ToString() + mensaje3.ElementAt(3).ToString();

                if (mensaje1.ElementAt(4).ToString() == mensaje2.ElementAt(4).ToString())
                {
                    palabra5 = mensaje1.ElementAt(4).ToString();
                }
                if (mensaje1.ElementAt(4).ToString() == mensaje3.ElementAt(4).ToString())
                {
                    palabra5 = mensaje1.ElementAt(4).ToString();
                }
                if (mensaje2.ElementAt(4).ToString() == mensaje3.ElementAt(4).ToString())
                {
                    palabra5 = mensaje2.ElementAt(4).ToString();
                }
                if (palabra5 == string.Empty)
                    palabra5 = mensaje1.ElementAt(4).ToString() + mensaje2.ElementAt(4).ToString() + mensaje3.ElementAt(4).ToString();

                emisor.Mensaje = palabra1 + " " + palabra2 + " " + palabra3 + " " +palabra4 + " " +palabra5;
                return emisor;
            }
            catch (Exception ex)
            {
                throw new Exception("Utilidades.Utilidad.GetMessage Mensaje: " +  ex.Message);
            }

        }

    }
}
