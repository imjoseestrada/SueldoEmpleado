using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaGUI
{
    abstract class Empleado
    {
        protected String nombreEmp, deptoEmp, puestoEmp;
        protected double sueldoQna;

        public void establecerNombreEmp(String nom)
        {
            nombreEmp = nom;
        }

        public void establecerDeptoEmp(String dep)
        {
            deptoEmp = dep;
        }

        public void establecerPuestoEmpo(String pue)
        {
            puestoEmp = pue;
        }

        public abstract Double calcularSueldoQna();

        public String obtenerNombreEmp()
        {
            return nombreEmp;
        }

        public String obtenerDeptoEmp()
        {
            return deptoEmp;
        }

        public String obtenerPuestoEmp()
        {
            return puestoEmp;
        }

        public double obtenerSueldoQna()
        {
            return sueldoQna;
        }
    }
}
