using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaGUI
{
    class EmpleadoTiempoCompleto : Empleado
    {
        double sueldoMensual;

        public void establecerSueldoMensual(double sue)
        {
            sueldoMensual = sue;
        }

        public override double calcularSueldoQna()
        {
            sueldoQna = sueldoMensual / 2;
            return sueldoQna;
        }
    }
}
