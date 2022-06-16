using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanillaAlumnosNotas
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

        public List<Materia>materias { get; set; }

        public Alumno()
        {
            this.materias = new List<Materia>();
        }

       
    }
}
