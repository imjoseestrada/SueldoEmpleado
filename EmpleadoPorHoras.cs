using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaGUI
{
    class EmpleadoPorHoras: Empleado
    {
        private int hrsTrab;
        private double pagoHr;

        public EmpleadoPorHoras(int hrsTrab, double pagoHr)
        {
            this.hrsTrab = hrsTrab;
            this.pagoHr = pagoHr;
        }

        public override double calcularSueldoQna()
        {
            sueldoQna = hrsTrab * pagoHr;
            return sueldoQna;
        }
    }
}
