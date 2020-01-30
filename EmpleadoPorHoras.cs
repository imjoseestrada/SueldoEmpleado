using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaGUI
{
    class EmpleadoPorHoras : Empleado
    {
        int horasTrab;
        double pagoHora;

        public void establecerHorasTrab(int HorasTr)
        {
            horasTrab = HorasTr;
        }

        public void establecerPagoHora(double pagoHr)
        {
            pagoHora = pagoHr;
        }

        public override double calcularSueldoQna()
        {
            sueldoQna = horasTrab * pagoHora;
            return sueldoQna;
        }
    }
}
