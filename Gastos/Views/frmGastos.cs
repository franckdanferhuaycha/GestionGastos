using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using GestionGastos.Config;
using GestionGastos.Controllers;
using GestionGastos.Models;



namespace GestionarGastos.Views
{
    public partial class frmGastos : Form
    {
        ConexionSqlite conexionSqlita = new ConexionSqlite();

        private readonly GastoController gastoController;



        public frmGastos()
        {
            InitializeComponent();

            gastoController = new GastoController();

        }

        private void Categoria(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Alimentacion");
            combo.Items.Add("Transporte");
            combo.Items.Add("Salud");
            combo.Items.Add("Educación");
            combo.Items.Add("Entritenimiento");
            combo.Items.Add("vivienda");
            combo.Items.Add("Servicios");
            combo.Items.Add("Compras");

        }
        private void Metodopago(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Efectivo");
            combo.Items.Add("Tarjeta");
            combo.Items.Add("Transferencia");
            combo.Items.Add("Yape");
            combo.Items.Add("plin");
            combo.Items.Add("Otros");

        }

        private void frmGastos_Load(object sender, EventArgs e)
        {
            Categoria(cbxCategoria);
            Metodopago(cbxMetodoPago);


            if (conexionSqlita.ProbarConexion())
            {
                //MessageBox.Show("Conexion exitosa ", "ÉXITO");

                lblEstatus.Text = "Conectado a la DB";
                lblEstatus.ForeColor = Color.Green;
            }

            else
            {
                // MessageBox.Show("no se peude conectar a la base de datos  ", "ALERTA");
                lblEstatus.Text = "No se tiene conexión ala base de datos";
                lblEstatus.ForeColor = Color.Red;



            }


        }

        //ESTO ES PARA MOSTRAR DATOS EN LA TABLA
        private void CargarTablaGasto(DataGridView data)
        {
            data.DataSource = null;
            data.DataSource = gastoController.ListarGasto();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("La descripcion no puede ser vacio", "Atencion");
                return;
            }

            if (cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar algun valor", "Atencion");
                return;
            }

            if (txtMonto.Value == 0)
            {
                MessageBox.Show("Debes ingresar algún monto", "Atencion");
                return;
            }

            if (cbxMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar método pago", "Atencion");
                return;
            }

            // haces una instancia
            Gasto gasto = new Gasto
            {
                Descripcion = txtDescripcion.Text,
                Categoria = cbxCategoria.Text,
                Monto = decimal.Parse(txtMonto.Value.ToString()),
                Fecha = dtpFecha.Value,
                MetodoPago = cbxMetodoPago.Text
            }
                            ;

            gastoController.Registrar(gasto);

            CargarTablaGasto(dgvTablaGastos);

            MessageBox.Show("Datos registrados correctamente", "Correcto!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTablaGastos.CurrentRow == null)
            {
                return;
            }

            int idGasto = Convert.ToInt32(dgvTablaGastos.CurrentRow.Cells["IdGasto"].Value);

            gastoController.Eliminar(idGasto);

            MessageBox.Show("Dato eliminado correctamente", "Eliminado!");


        }
    }
}
