using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm
{
    public class Persona
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Sexo { get; set; }
        public bool[] GenerosFavoritos { get; set; }
        public string ColorFavorito { get; set; }
        
        public Persona()
        {
            GenerosFavoritos = new bool[6];
        }
    }
}
