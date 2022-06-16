using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanillaAlumnosNotas
{
    class Materia
    {
        public string NombMateria { get; set; }
        public List<decimal>notas { get; set; }

        public  Materia()
        {
            this.notas = new List<decimal>();
        }

    }
}
