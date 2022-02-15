namespace WinFormsAlunos
{
    partial class EditarProfessor
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbApelido = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbIdProfessor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(208, 201);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 40);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(110, 201);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 40);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbApelido
            // 
            this.tbApelido.Location = new System.Drawing.Point(62, 153);
            this.tbApelido.Name = "tbApelido";
            this.tbApelido.Size = new System.Drawing.Size(237, 23);
            this.tbApelido.TabIndex = 7;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(62, 107);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(237, 23);
            this.tbNome.TabIndex = 6;
            // 
            // tbIdProfessor
            // 
            this.tbIdProfessor.Location = new System.Drawing.Point(62, 63);
            this.tbIdProfessor.Name = "tbIdProfessor";
            this.tbIdProfessor.Size = new System.Drawing.Size(62, 23);
            this.tbIdProfessor.TabIndex = 5;
            // 
            // EditarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 297);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbApelido);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbIdProfessor);
            this.Name = "EditarProfessor";
            this.Text = "EditarProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbApelido;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbIdProfessor;
    }
}