using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldoEmpleado
{
    class EmpleadoTiempoCompleto: Empleado
    {
        private double sueldoMensual;

        public EmpleadoTiempoCompleto(double sueldoMensual)
        {
            this.sueldoMensual = sueldoMensual;
        }

        public override double calcularSueldoQna()
        {
            sueldoQna = sueldoMensual / 2;
            return sueldoQna;
        }
    }
}
