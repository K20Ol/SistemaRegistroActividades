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
    public partial class CUOrganizadores : UserControl
    {
        public CUOrganizadores()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtInstitucion.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }
        private void CargarDatosEnGrid()
        {
            csOrganizadores logica = new csOrganizadores();
            var lista = logica.LeerOrganizadores();

            dgvDatos.DataSource = null; 
            dgvDatos.DataSource = lista;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dtoOrganizadores organizador = new dtoOrganizadores
            {
                Nombre = txtNombre.Text,
                Institucion = txtInstitucion.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text
            };

            csOrganizadores logica = new csOrganizadores();
            bool resultado = logica.InsertarOrganizador(organizador);

            if (resultado)
            {
                MessageBox.Show("Organizador guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); CargarDatosEnGrid();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar el organizador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CUOrganizadores_Load(object sender, EventArgs e)
        {
            CargarDatosEnGrid();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtoOrganizadores organizador = new dtoOrganizadores
            {
                Nombre = txtNombre.Text,
                Institucion = txtInstitucion.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                ID_Organizador = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells["ID_Organizador"].Value)
            };

            csOrganizadores logica = new csOrganizadores();
            bool resultado = logica.ActualizarOrganizador(organizador);

            if (resultado)
            {
                MessageBox.Show("Organizador actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosEnGrid(); // Actualiza el DataGridView
                btnGuardar.Enabled = true; // Habilita el botón de guardar
                btnActualizar.Enabled = false; // Deshabilita el botón de actualizar
            }
            else
            {
                MessageBox.Show("Ocurrió un error al actualizar el organizador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDatos.Rows[e.RowIndex];

                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtInstitucion.Text = fila.Cells["Institucion"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();

                btnGuardar.Enabled = false; // Bloquea el botón de guardar
                btnActualizar.Enabled = true; // Habilita el botón de actualizar
            }
        }
    }
}
