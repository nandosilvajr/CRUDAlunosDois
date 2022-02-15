using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAlunos
{
    public partial class EditarAluno : Form
    {
        Aluno _editado;
        Form1 _form1;
        public EditarAluno(Form1 form1, Aluno editado)
        {
            InitializeComponent();

            _editado = editado;
            _form1 = form1;

            tbIdAluno.Text = editado.AlunoId.ToString();
            tbNome.Text = editado?.Nome;
            tbApelido.Text = editado?.Apelido;
                
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(ValidaForm())
            {
                _editado.Nome = tbNome.Text;
                _editado.Apelido = tbApelido.Text;
                _form1.populaLista();
                this.Close();
            }
        }

        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("É necessário preencher o nome do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(tbApelido.Text))
            {
                MessageBox.Show("É necessário preencher o apelido do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }
    }
}
