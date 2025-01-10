using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroActividades.Datos
{
    internal class dtoActividadesParticipantes
    {
        public int ID_Actividad { get; set; }
        public int ID_Participante { get; set; }
        public DateTime Fecha_Inscripcion { get; set; }
        public string Rol { get; set; }
        public bool Asistencia { get; set; }
        public string Observaciones { get; set; }
    }
}
