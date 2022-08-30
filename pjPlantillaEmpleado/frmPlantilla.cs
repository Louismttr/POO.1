using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPlantillaEmpleado
{
    public partial class frmPlantilla : Form
    {
        public frmPlantilla()
        {
            InitializeComponent();
        }

        private void frmPlantilla_Load(object sender, EventArgs e)
        {
            mostrarFecha();
            mostrarMesActual();
        }

        //Implementacion de metodos
        //1. Mostrar la fecha actual

        private void mostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void mostrarMesActual()
        {
            txtMes.Text = DateTime.Now.Month.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtAños.Text = (DateTime.Now.Year - dtFechaIngreso.Value.Year).ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            dtFechaIngreso.Value = DateTime.Now;
            cboCargo.Text = "(Seleccione cargo)";
            txtMes.Clear();
            txtAños.Clear();

            lblSueldoBasico.Text = (0).ToString("C");
            lblGratificacion.Text = (0).ToString("C");
            lblComission.Text= (0).ToString("C");
            lblCooperativa.Text = (0).ToString("C");
            lblSeguroSocial.Text=(0).ToString("C");

            lblTotalAportaciones.Text = (0).ToString("C");
            lblTotalDescuento.Text = (0).ToString("C");
            lblTotalIngreso.Text = (0).ToString("C");
            lblTotalNeto.Text = (0).ToString("C");

            txtEmpleado.Focus();

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Capturando datos
            string empleado = txtEmpleado.Text;
            string cargo = cboCargo.Text;
            DateTime fechaIngreso = dtFechaIngreso.Value;
            int años = int.Parse(txtAños.Text);

            //objecto de la clase plantilla
            Planilla objP = new Planilla();
            objP.empleado = empleado;
            objP.cargo = cargo;
            objP.fechaIngreso = fechaIngreso;
            objP.years = años;

            //Realizamos la impresion de valores
            txtMes.Text = objP.mesConsultado();
            lblSueldoBasico.Text = objP.DeterminarBasico().ToString("C");
            lblGratificacion.Text = objP.DeterminaGratificacion().ToString("C");
            lblComission.Text=objP.DeterminaComision().ToString("C");
            lblCooperativa.Text = objP.DeterminaDescuentoCooperativa().ToString("C");
            lblSeguroSocial.Text=objP.DeterminaAportacionSeguro().ToString("C");

            lblTotalIngreso.Text=objP.CalculaToatalAportaciobnes().ToString("C");
            lblTotalDescuento.Text=objP.TotalDescuentos().ToString("C");
            lblTotalAportaciones.Text=objP.CalculaToatalAportaciobnes().ToString("C");

            lblTotalNeto.Text=objP.DeterminaNeto().ToString("C");
        }
    }
}
