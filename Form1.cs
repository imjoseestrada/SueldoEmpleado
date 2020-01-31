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
    public partial class Form1: Form
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
            panel1.Enabled = true;
            panel2.Enabled = false;
        }

        private void rbTiempoCompleto_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            panel1.Enabled = false;
            panel2.Enabled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String nombre, depto, puesto;
            int hrsTrab;
            double pagoHr, sueldoMesual;

            nombre = txtNombre.Text;
            depto = txtDepartamento.Text;
            puesto = txtPuesto.Text;

            if (nombre != "" && depto != "" && puesto != "")
            {
                try
                {
                    Empleado[] Empleados = new Empleado[1];

                    if (rbPagoHoras.Checked)
                    {
                        hrsTrab = Convert.ToInt32(txtHorasTrab.Text);
                        pagoHr = Convert.ToDouble(txtPagoHr.Text);

                        Empleados[0] = new EmpleadoPorHoras(hrsTrab, pagoHr);
                    }
                    if(rbTiempoCompleto.Checked)
                    {
                        sueldoMesual = Convert.ToDouble(txtSueldoMensual.Text);

                        Empleados[0] = new EmpleadoTiempoCompleto(sueldoMesual);
                    }

                    Empleados[0].setNombre(nombre);
                    Empleados[0].setDepto(depto);
                    Empleados[0].setPuesto(puesto);

                    Empleados[0].calcularSueldoQna();

                    // impresiones
                    txtImpresiones.Text = "Nombre del empleado: " + Empleados[0].getNombre() + Environment.NewLine + "Departamento: " + Empleados[0].getDepto() + Environment.NewLine + "Puesto: " + Empleados[0].getPuesto() + Environment.NewLine + "Sueldo quincenal: " + Empleados[0].getSueldoQna();

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
                    MessageBox.Show("Ingresar sólo números para calcular el sueldo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } else
            {
                MessageBox.Show("Todos los campos deben ser completados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(sender, e);
        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(sender, e);
        }

        private void txtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(sender, e);
        }

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Ingresar sólo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
