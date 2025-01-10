using SistemaRegistroActividades.Datos;
using SistemaRegistroActividades.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistroActividades.Presentacion
{
    public partial class CUActividades : UserControl
    {
        private csActividades logica = new csActividades();
        public CUActividades()
        {
            InitializeComponent();
        }
        private void CargarOrganizadores()
        {
            csOrganizadores logicaOrganizadores = new csOrganizadores();
            var organizadores = logicaOrganizadores.LeerOrganizadores();

            cmbOrganizador.DataSource = organizadores;
            cmbOrganizador.DisplayMember = "Nombre";
            cmbOrganizador.ValueMember = "ID_Organizador";
            cmbOrganizador.SelectedIndex = -1;
        }
        private void CargarDatosEnGrid()
        {
            csActividades logica = new csActividades();
            var lista = logica.LeerActividades();

            dgvDatos.DataSource = null; 
            dgvDatos.DataSource = lista;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dtoActividades actividad = new dtoActividades
            {
                Nombre = txtNombre.Text,
                Fecha = dtpFecha.Value,
                Lugar = txtLugar.Text,
                Descripcion = txtDescripcion.Text,
                ID_Organizador = Convert.ToInt32(cmbOrganizador.SelectedValue)
            };

            bool resultado = logica.InsertarActividad(actividad);

            if (resultado)
            {
                MessageBox.Show("Actividad guardada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); CargarDatosEnGrid();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar la actividad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtLugar.Clear();
            txtDescripcion.Clear();
            dtpFecha.Value = DateTime.Now;
            cmbOrganizador.SelectedIndex = -1;
        }

        private void CUActividades_Load(object sender, EventArgs e)
        {
            CargarOrganizadores(); CargarDatosEnGrid();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDatos.Rows[e.RowIndex];

                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
                txtLugar.Text = fila.Cells["Lugar"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                cmbOrganizador.SelectedValue = Convert.ToInt32(fila.Cells["ID_Organizador"].Value);

                btnGuardar.Enabled = false; // Bloquea el botón de guardar
                btnActualizar.Enabled = true; // Habilita el botón de actualizar
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtoActividades actividad = new dtoActividades
            {
                Nombre = txtNombre.Text,
                Fecha = dtpFecha.Value,
                Lugar = txtLugar.Text,
                Descripcion = txtDescripcion.Text,
                ID_Organizador = Convert.ToInt32(cmbOrganizador.SelectedValue),
                ID_Actividad = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells["ID_Actividad"].Value)
            };

            csActividades logica = new csActividades();
            bool resultado = logica.ActualizarActividad(actividad);

            if (resultado)
            {
                MessageBox.Show("Actividad actualizada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosEnGrid(); // Actualiza el DataGridView
                btnGuardar.Enabled = true; // Habilita el botón de guardar
                btnActualizar.Enabled = false; // Deshabilita el botón de actualizar
            }
            else
            {
                MessageBox.Show("Ocurrió un error al actualizar la actividad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
