using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAlunos
{
    public partial class EditarProfessor : Form
    {
        Professor _editado;
        Professores _professorForm;
        public EditarProfessor(Professores professores, Professor professorEditado)
        {
            InitializeComponent();

            _editado = professorEditado;
           _professorForm = professores;

            tbIdProfessor.Text = professorEditado.ProfessorId.ToString();
            tbNome.Text = professorEditado?.Nome;
            tbApelido.Text = professorEditado?.Apelido;

        }
     

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                _editado.Nome = tbNome.Text;
                _editado.Apelido = tbApelido.Text;
                _professorForm.populaLista();
                this.Close();
            }
        }

        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("É necessário preencher o nome do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(tbApelido.Text))
            {
                MessageBox.Show("É necessário preencher o apelido do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }
    }
}
