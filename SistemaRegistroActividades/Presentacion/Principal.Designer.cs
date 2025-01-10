namespace SistemaRegistroActividades
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnParticipantes = new System.Windows.Forms.Button();
            this.btnOrganizadores = new System.Windows.Forms.Button();
            this.btnActividades = new System.Windows.Forms.Button();
            this.pnlBaseFormularios = new System.Windows.Forms.Panel();
            this.btnAsistencias = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 41);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(908, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 33);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de registro de actividades";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.panel2.Controls.Add(this.btnAsistencias);
            this.panel2.Controls.Add(this.btnParticipantes);
            this.panel2.Controls.Add(this.btnOrganizadores);
            this.panel2.Controls.Add(this.btnActividades);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 422);
            this.panel2.TabIndex = 1;
            // 
            // btnParticipantes
            // 
            this.btnParticipantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParticipantes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipantes.Location = new System.Drawing.Point(0, 130);
            this.btnParticipantes.Name = "btnParticipantes";
            this.btnParticipantes.Size = new System.Drawing.Size(164, 65);
            this.btnParticipantes.TabIndex = 2;
            this.btnParticipantes.Text = "Participantes";
            this.btnParticipantes.UseVisualStyleBackColor = true;
            this.btnParticipantes.Click += new System.EventHandler(this.btnParticipantes_Click);
            // 
            // btnOrganizadores
            // 
            this.btnOrganizadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrganizadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizadores.Location = new System.Drawing.Point(0, 65);
            this.btnOrganizadores.Name = "btnOrganizadores";
            this.btnOrganizadores.Size = new System.Drawing.Size(164, 65);
            this.btnOrganizadores.TabIndex = 1;
            this.btnOrganizadores.Text = "Organizadores";
            this.btnOrganizadores.UseVisualStyleBackColor = true;
            this.btnOrganizadores.Click += new System.EventHandler(this.btnOrganizadores_Click);
            // 
            // btnActividades
            // 
            this.btnActividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActividades.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActividades.Location = new System.Drawing.Point(0, 0);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Size = new System.Drawing.Size(164, 65);
            this.btnActividades.TabIndex = 0;
            this.btnActividades.Text = "Actividades";
            this.btnActividades.UseVisualStyleBackColor = true;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // pnlBaseFormularios
            // 
            this.pnlBaseFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBaseFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaseFormularios.Location = new System.Drawing.Point(164, 41);
            this.pnlBaseFormularios.Name = "pnlBaseFormularios";
            this.pnlBaseFormularios.Size = new System.Drawing.Size(786, 422);
            this.pnlBaseFormularios.TabIndex = 2;
            // 
            // btnAsistencias
            // 
            this.btnAsistencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsistencias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencias.Location = new System.Drawing.Point(0, 195);
            this.btnAsistencias.Name = "btnAsistencias";
            this.btnAsistencias.Size = new System.Drawing.Size(164, 65);
            this.btnAsistencias.TabIndex = 3;
            this.btnAsistencias.Text = "Asistencias";
            this.btnAsistencias.UseVisualStyleBackColor = true;
            this.btnAsistencias.Click += new System.EventHandler(this.btnAsistencias_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 463);
            this.Controls.Add(this.pnlBaseFormularios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnParticipantes;
        private System.Windows.Forms.Button btnOrganizadores;
        private System.Windows.Forms.Button btnActividades;
        private System.Windows.Forms.Panel pnlBaseFormularios;
        private System.Windows.Forms.Button btnAsistencias;
    }
}

