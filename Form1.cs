using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // deshabilitar & habilitar botones
            txtNombre.Enabled = true;
            txtDepartamento.Enabled = true;
            txtPuesto.Enabled = true;
            rbTiempoCompleto.Enabled = true;
            rbPagoHoras.Enabled = true;
            btnCalcular.Enabled = true;
            btnNuevo.Enabled = false;
            panel1.Enabled = true;
            panel2.Enabled = true;

            // limpiar campos
            txtNombre.Text = null;
            txtDepartamento.Text = null;
            txtPuesto.Text = null;
            rbPagoHoras.Checked = false;
            rbTiempoCompleto.Checked = false;
            txtHorasTrab.Text = null;
            txtPagoHr.Text = null;
            txtSueldoMensual.Text = null;
            txtImpresiones.Text = null;

            txtNombre.Focus();
        }

        private void rbPagoHoras_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void rbTiempoCompleto_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String nomEmp, depto, puesto;
            int hrsTrab;
            double pagoHr, sueldoMesual;

            nomEmp = txtNombre.Text;
            depto = txtDepartamento.Text;
            puesto = txtPuesto.Text;

            if (nomEmp != "" && depto != "" && puesto != "")
            {
                try
                {
                    if (rbPagoHoras.Checked)
                    {
                        EmpleadoPorHoras objEmpleado = new EmpleadoPorHoras();

                        hrsTrab = Convert.ToInt32(txtHorasTrab.Text);
                        pagoHr = Convert.ToDouble(txtPagoHr.Text);

                        objEmpleado.establecerNombreEmp(nomEmp);
                        objEmpleado.establecerDeptoEmp(depto);
                        objEmpleado.establecerPuestoEmpo(puesto);
                        objEmpleado.establecerHorasTrab(hrsTrab);
                        objEmpleado.establecerPagoHora(pagoHr);

                        objEmpleado.calcularSueldoQna();

                        // impresiones
                        txtImpresiones.Text = "Nombre del empleado: " + objEmpleado.obtenerNombreEmp() + Environment.NewLine + "Departamento: " + objEmpleado.obtenerDeptoEmp() + Environment.NewLine + "Puesto: " + objEmpleado.obtenerPuestoEmp() + Environment.NewLine + "Sueldo quincenal: " + objEmpleado.obtenerSueldoQna();

                    }
                    else
                    {
                        EmpleadoTiempoCompleto objEmpleado = new EmpleadoTiempoCompleto();

                        sueldoMesual = Convert.ToDouble(txtSueldoMensual.Text);

                        objEmpleado.establecerNombreEmp(nomEmp);
                        objEmpleado.establecerDeptoEmp(depto);
                        objEmpleado.establecerPuestoEmpo(puesto);
                        objEmpleado.establecerSueldoMensual(sueldoMesual);

                        objEmpleado.calcularSueldoQna();

                        // impresiones
                        txtImpresiones.Text = "Nombre del empleado: " + objEmpleado.obtenerNombreEmp() + Environment.NewLine + "Departamento: " + objEmpleado.obtenerDeptoEmp() + Environment.NewLine + "Puesto: " + objEmpleado.obtenerPuestoEmp() + Environment.NewLine + "Sueldo quincenal: " + objEmpleado.obtenerSueldoQna();
                    }

                    // deshabilitar & habilitar botones
                    txtNombre.Enabled = false;
                    txtDepartamento.Enabled = false;
                    txtPuesto.Enabled = false;
                    rbPagoHoras.Enabled = false;
                    rbTiempoCompleto.Enabled = false;
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    btnCalcular.Enabled = false;
                    btnNuevo.Enabled = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Debe ingresar números para calcular el sueldo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Todos los campos deben ser completados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
