using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroActividades.Datos
{
    internal class dtoActividades
    {
        public int ID_Actividad { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Descripcion { get; set; }
        public int ID_Organizador { get; set; }
    }
}
