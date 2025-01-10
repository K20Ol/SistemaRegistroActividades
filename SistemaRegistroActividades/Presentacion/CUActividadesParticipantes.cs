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
    public partial class CUActividadesParticipantes : UserControl
    {
        public CUActividadesParticipantes()
        {
            InitializeComponent();
        }

        private void CUActividadesParticipantes_Load(object sender, EventArgs e)
        {
            CargarDatosEnGrid();
            CargarActividades();
            CargarParticipantes();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dtoActividadesParticipantes participacion = new dtoActividadesParticipantes
            {
                ID_Actividad = Convert.ToInt32(cmbActividad.SelectedValue),
                ID_Participante = Convert.ToInt32(cmbParticipante.SelectedValue),
                Fecha_Inscripcion = DateTime.Now,
                Rol = cmbRol.Text,
                Asistencia = chkAsistencia.Checked,
                Observaciones = txtObservacion.Text
            };

            csActividadesParticipantes logica = new csActividadesParticipantes();
            bool resultado = logica.Insertar(participacion);

            if (resultado)
            {
                MessageBox.Show("Participación guardada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosEnGrid();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar la participación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtoActividadesParticipantes participacion = new dtoActividadesParticipantes
            {
                ID_Actividad = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells["ID_Actividad"].Value),
                ID_Participante = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells["ID_Participante"].Value),
                Fecha_Inscripcion = DateTime.Now, // Actualiza con la fecha actual
                Rol = cmbRol.Text,
                Asistencia = chkAsistencia.Checked,
                Observaciones = txtObservacion.Text
            };

            csActividadesParticipantes logica = new csActividadesParticipantes();
            bool resultado = logica.Actualizar(participacion);

            if (resultado)
            {
                MessageBox.Show("Participación actualizada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosEnGrid();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al actualizar la participación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDatos.Rows[e.RowIndex];

                cmbActividad.SelectedValue = fila.Cells["ID_Actividad"].Value;
                cmbParticipante.SelectedValue = fila.Cells["ID_Participante"].Value;
                cmbRol.Text = fila.Cells["Rol"].Value.ToString();
                chkAsistencia.Checked = Convert.ToBoolean(fila.Cells["Asistencia"].Value);
                txtObservacion.Text = fila.Cells["Observaciones"].Value.ToString();

                btnGuardar.Enabled = false;
                btnActualizar.Enabled = true;
            }
        }
        private void CargarDatosEnGrid()
        {
            csActividadesParticipantes logica = new csActividadesParticipantes();
            var lista = logica.Listar();

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista;
        }
        private void CargarActividades()
        {
            csActividades logica = new csActividades();
            var lista = logica.LeerActividades();

            cmbActividad.DataSource = lista;
            cmbActividad.DisplayMember = "Nombre";
            cmbActividad.ValueMember = "ID_Actividad";
            cmbActividad.SelectedIndex = -1;
        }

        private void CargarParticipantes()
        {
            csParticipantes logica = new csParticipantes();
            var lista = logica.LeerParticipantes();

            cmbParticipante.DataSource = lista;
            cmbParticipante.DisplayMember = "Nombre";
            cmbParticipante.ValueMember = "ID_Participante";
            cmbParticipante.SelectedIndex = -1;
        }
        private void LimpiarCampos()
        {
            cmbActividad.SelectedIndex = -1; 
            cmbParticipante.SelectedIndex = -1; 
            cmbRol.SelectedIndex = -1;
            chkAsistencia.Checked = false; 
            txtObservacion.Clear(); 

            btnGuardar.Enabled = true; 
            btnActualizar.Enabled = false;
        }

    }
}
