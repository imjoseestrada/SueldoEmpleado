using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaGUI
{
    abstract class Empleado
    {
        protected String nombre, depto, puesto;
        protected double sueldoQna;

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setDepto(String depto)
        {
            this.depto = depto;
        }

        public void setPuesto(String puesto)
        {
            this.puesto = puesto;
        }

        public abstract Double calcularSueldoQna();

        public String getNombre()
        {
            return nombre;
        }

        public String getDepto()
        {
            return depto;
        }

        public String getPuesto()
        {
            return puesto;
        }

        public double getSueldoQna()
        {
            return sueldoQna;
        }
    }
}
