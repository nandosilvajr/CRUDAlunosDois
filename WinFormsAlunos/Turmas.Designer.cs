namespace WinFormsAlunos
{
    partial class Turmas
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbIdturma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProfessores = new System.Windows.Forms.ListBox();
            this.btnAdicionarAluno = new System.Windows.Forms.Button();
            this.btnRemoverAluno = new System.Windows.Forms.Button();
            this.lbAlunoTurma = new System.Windows.Forms.ListBox();
            this.btnRemoverProfessor = new System.Windows.Forms.Button();
            this.btnAddProfessor = new System.Windows.Forms.Button();
            this.lbProfessorTurma = new System.Windows.Forms.ListBox();
            this.lblListaAlunos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAlunos
            // 
            this.lbAlunos.FormattingEnabled = true;
            this.lbAlunos.ItemHeight = 15;
            this.lbAlunos.Location = new System.Drawing.Point(51, 102);
            this.lbAlunos.Name = "lbAlunos";
            this.lbAlunos.Size = new System.Drawing.Size(227, 139);
            this.lbAlunos.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(528, 462);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 48);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(438, 462);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 48);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbIdturma
            // 
            this.tbIdturma.Enabled = false;
            this.tbIdturma.Location = new System.Drawing.Point(92, 36);
            this.tbIdturma.Name = "tbIdturma";
            this.tbIdturma.Size = new System.Drawing.Size(133, 23);
            this.tbIdturma.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id";
            // 
            // lbProfessores
            // 
            this.lbProfessores.FormattingEnabled = true;
            this.lbProfessores.ItemHeight = 15;
            this.lbProfessores.Location = new System.Drawing.Point(48, 286);
            this.lbProfessores.Name = "lbProfessores";
            this.lbProfessores.Size = new System.Drawing.Size(230, 139);
            this.lbProfessores.TabIndex = 22;
            // 
            // btnAdicionarAluno
            // 
            this.btnAdicionarAluno.Location = new System.Drawing.Point(284, 115);
            this.btnAdicionarAluno.Name = "btnAdicionarAluno";
            this.btnAdicionarAluno.Size = new System.Drawing.Size(93, 23);
            this.btnAdicionarAluno.TabIndex = 25;
            this.btnAdicionarAluno.Text = "Adicionar >>";
            this.btnAdicionarAluno.UseVisualStyleBackColor = true;
            this.btnAdicionarAluno.Click += new System.EventHandler(this.btnAdicionarAluno_Click);
            // 
            // btnRemoverAluno
            // 
            this.btnRemoverAluno.Location = new System.Drawing.Point(284, 193);
            this.btnRemoverAluno.Name = "btnRemoverAluno";
            this.btnRemoverAluno.Size = new System.Drawing.Size(93, 23);
            this.btnRemoverAluno.TabIndex = 26;
            this.btnRemoverAluno.Text = "<< Remover";
            this.btnRemoverAluno.UseVisualStyleBackColor = true;
            this.btnRemoverAluno.Click += new System.EventHandler(this.btnRemoverAluno_Click);
            // 
            // lbAlunoTurma
            // 
            this.lbAlunoTurma.FormattingEnabled = true;
            this.lbAlunoTurma.ItemHeight = 15;
            this.lbAlunoTurma.Location = new System.Drawing.Point(402, 102);
            this.lbAlunoTurma.Name = "lbAlunoTurma";
            this.lbAlunoTurma.Size = new System.Drawing.Size(227, 139);
            this.lbAlunoTurma.TabIndex = 27;
            // 
            // btnRemoverProfessor
            // 
            this.btnRemoverProfessor.Location = new System.Drawing.Point(284, 381);
            this.btnRemoverProfessor.Name = "btnRemoverProfessor";
            this.btnRemoverProfessor.Size = new System.Drawing.Size(93, 23);
            this.btnRemoverProfessor.TabIndex = 29;
            this.btnRemoverProfessor.Text = "<< Remover";
            this.btnRemoverProfessor.UseVisualStyleBackColor = true;
            this.btnRemoverProfessor.Click += new System.EventHandler(this.btnRemoverProfessor_Click);
            // 
            // btnAddProfessor
            // 
            this.btnAddProfessor.Location = new System.Drawing.Point(284, 303);
            this.btnAddProfessor.Name = "btnAddProfessor";
            this.btnAddProfessor.Size = new System.Drawing.Size(93, 23);
            this.btnAddProfessor.TabIndex = 28;
            this.btnAddProfessor.Text = "Adicionar >>";
            this.btnAddProfessor.UseVisualStyleBackColor = true;
            this.btnAddProfessor.Click += new System.EventHandler(this.btnAddProfessor_Click);
            // 
            // lbProfessorTurma
            // 
            this.lbProfessorTurma.FormattingEnabled = true;
            this.lbProfessorTurma.ItemHeight = 15;
            this.lbProfessorTurma.Location = new System.Drawing.Point(402, 286);
            this.lbProfessorTurma.Name = "lbProfessorTurma";
            this.lbProfessorTurma.Size = new System.Drawing.Size(227, 139);
            this.lbProfessorTurma.TabIndex = 30;
            // 
            // lblListaAlunos
            // 
            this.lblListaAlunos.AutoSize = true;
            this.lblListaAlunos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaAlunos.Location = new System.Drawing.Point(51, 80);
            this.lblListaAlunos.Name = "lblListaAlunos";
            this.lblListaAlunos.Size = new System.Drawing.Size(89, 15);
            this.lblListaAlunos.TabIndex = 31;
            this.lblListaAlunos.Text = "Lista de Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Lista de Professores";
            // 
            // Turmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblListaAlunos);
            this.Controls.Add(this.lbProfessorTurma);
            this.Controls.Add(this.btnRemoverProfessor);
            this.Controls.Add(this.btnAddProfessor);
            this.Controls.Add(this.lbAlunoTurma);
            this.Controls.Add(this.btnRemoverAluno);
            this.Controls.Add(this.btnAdicionarAluno);
            this.Controls.Add(this.lbProfessores);
            this.Controls.Add(this.lbAlunos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbIdturma);
            this.Controls.Add(this.label1);
            this.Name = "Turmas";
            this.Text = "Turmas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbAlunos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbIdturma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbProfessores;
        private System.Windows.Forms.Button btnAdicionarAluno;
        private System.Windows.Forms.Button btnRemoverAluno;
        private System.Windows.Forms.ListBox lbAlunoTurma;
        private System.Windows.Forms.Button btnRemoverProfessor;
        private System.Windows.Forms.Button btnAddProfessor;
        private System.Windows.Forms.ListBox lbProfessorTurma;
        private System.Windows.Forms.Label lblListaAlunos;
        private System.Windows.Forms.Label label2;
    }
}