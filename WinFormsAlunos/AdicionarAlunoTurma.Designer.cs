namespace WinFormsAlunos
{
    partial class AdicionarAlunoTurma
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
            this.lbAlunos = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lbAlunoTurma = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAlunos
            // 
            this.lbAlunos.FormattingEnabled = true;
            this.lbAlunos.ItemHeight = 15;
            this.lbAlunos.Location = new System.Drawing.Point(12, 64);
            this.lbAlunos.Name = "lbAlunos";
            this.lbAlunos.Size = new System.Drawing.Size(165, 139);
            this.lbAlunos.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(196, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 24);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(196, 138);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(71, 24);
            this.btnRemover.TabIndex = 22;
            this.btnRemover.Text = "<<";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // lbAlunoTurma
            // 
            this.lbAlunoTurma.FormattingEnabled = true;
            this.lbAlunoTurma.ItemHeight = 15;
            this.lbAlunoTurma.Location = new System.Drawing.Point(273, 64);
            this.lbAlunoTurma.Name = "lbAlunoTurma";
            this.lbAlunoTurma.Size = new System.Drawing.Size(165, 139);
            this.lbAlunoTurma.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(311, 220);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 51);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // AdicionarAlunoTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 283);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbAlunoTurma);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbAlunos);
            this.Name = "AdicionarAlunoTurma";
            this.Text = "AdicionarAlunoTurma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAlunos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListBox lbAlunoTurma;
        private System.Windows.Forms.Button btnGuardar;
    }
}