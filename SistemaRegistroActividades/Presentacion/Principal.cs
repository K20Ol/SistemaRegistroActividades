using SistemaRegistroActividades.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistroActividades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            CUActividades frmPrueba = new CUActividades();
            pnlBaseFormularios.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            pnlBaseFormularios.Controls.Add(frmPrueba);
        }

        private void btnOrganizadores_Click(object sender, EventArgs e)
        {
            CUOrganizadores frmPrueba = new CUOrganizadores();
            pnlBaseFormularios.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            pnlBaseFormularios.Controls.Add(frmPrueba);
        }

        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            CUParticipantes frmPrueba = new CUParticipantes();
            pnlBaseFormularios.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            pnlBaseFormularios.Controls.Add(frmPrueba);
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            CUActividadesParticipantes frmPrueba = new CUActividadesParticipantes();
            pnlBaseFormularios.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            pnlBaseFormularios.Controls.Add(frmPrueba);
        }
    }
}
