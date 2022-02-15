namespace WinFormsAlunos
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProfessores = new System.Windows.Forms.Button();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnTurmas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfessores
            // 
            this.btnProfessores.Location = new System.Drawing.Point(85, 91);
            this.btnProfessores.Name = "btnProfessores";
            this.btnProfessores.Size = new System.Drawing.Size(75, 63);
            this.btnProfessores.TabIndex = 0;
            this.btnProfessores.Text = "Professores";
            this.btnProfessores.UseVisualStyleBackColor = true;
            this.btnProfessores.Click += new System.EventHandler(this.btnProfessores_Click);
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(160, 91);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(75, 63);
            this.btnAlunos.TabIndex = 1;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnTurmas
            // 
            this.btnTurmas.Enabled = false;
            this.btnTurmas.Location = new System.Drawing.Point(235, 91);
            this.btnTurmas.Name = "btnTurmas";
            this.btnTurmas.Size = new System.Drawing.Size(75, 63);
            this.btnTurmas.TabIndex = 2;
            this.btnTurmas.Text = "Turmas";
            this.btnTurmas.UseVisualStyleBackColor = true;
            this.btnTurmas.Click += new System.EventHandler(this.btnTurmas_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 271);
            this.Controls.Add(this.btnTurmas);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.btnProfessores);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfessores;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnTurmas;
    }
}