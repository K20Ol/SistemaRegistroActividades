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
    public partial class CUParticipantes : UserControl
    {
        public CUParticipantes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dtoParticipantes participante = new dtoParticipantes
            {
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text
            };

            csParticipantes logica = new csParticipantes();
            bool resultado = logica.InsertarParticipante(participante);

            if (resultado)
            {
                MessageBox.Show("Participante guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosEnGrid();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar el participante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtoParticipantes participante = new dtoParticipantes
            {
                ID_Participante = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells["ID_Participante"].Value),
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text
            };

            csParticipantes logica = new csParticipantes();
            bool resultado = logica.ActualizarParticipante(participante);

            if (resultado)
            {
                MessageBox.Show("Participante actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosEnGrid();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al actualizar el participante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private void CargarDatosEnGrid()
        {
            csParticipantes logica = new csParticipantes();
            var lista = logica.LeerParticipantes();

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista;
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDatos.Rows[e.RowIndex];

                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();

                btnGuardar.Enabled = false;
                btnActualizar.Enabled = true;
            }
        }

        private void CUParticipantes_Load(object sender, EventArgs e)
        {
            CargarDatosEnGrid();
        }
    }
}
