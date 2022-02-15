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
    public partial class Form1 : Form
    {

        int contaAlunos = 1;
        public List<Aluno> alunosLista;
        public Principal _principal;
        public Form1(Principal principal)
        {
            InitializeComponent();
            alunosLista = new List<Aluno>();
            tbIdAluno.Text = contaAlunos.ToString();
            _principal = principal;
        }

        private bool ValidaForm()
        {
            bool output = true;

            if(string.IsNullOrEmpty(tbNome.Text))
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Aluno aluno;
            
            if (ValidaForm())
            {
                aluno = new Aluno
                {
                    AlunoId = contaAlunos,
                    Nome = tbNome.Text,
                    Apelido = tbApelido.Text
                };

                alunosLista.Add(aluno);
                contaAlunos++;
                tbIdAluno.Text = contaAlunos.ToString();
                populaLista();
            } else
            {
                MessageBox.Show("É necessário preencher as informações dos alunos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            tbNome.Text = string.Empty;
            tbApelido.Text = string.Empty;
        }

        public void populaLista()
        {
            lbAlunos.DataSource = null;
            lbAlunos.DataSource = alunosLista.ToList();
            lbAlunos.DisplayMember = "NomeCompleto";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbNome.Text = string.Empty;
            tbApelido.Text = string.Empty;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Aluno alunoApagar = lbAlunos.SelectedItem as Aluno;

            Aluno alunoApagado = null;

            if (alunoApagar != null)
            {
                foreach(Aluno al in alunosLista)
                {
                    if(al.AlunoId == alunoApagar.AlunoId)
                    {
                        alunoApagado = al;
                    }
                }
            }
            if(alunoApagado != null)
            {
                DialogResult result;
                result = MessageBox.Show($"Tem certeza que deseja apagar o aluno {alunoApagado.Nome}?",
                    "Apagar",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if(result == DialogResult.OK)
                {
                    alunosLista.Remove(alunoApagado);
                    populaLista();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Aluno alunoEditar = lbAlunos.SelectedItem as Aluno;

            Aluno alunoEditado = null;

            if (alunoEditar != null)
            {
                foreach (Aluno al in alunosLista)
                {
                    if (al.AlunoId == alunoEditar.AlunoId)
                    {
                        alunoEditado= al;
                    }
                }
            }
            if (alunoEditado!= null)
            {
                DialogResult result;
                result = MessageBox.Show($"Tem certeza que deseja editar o aluno {alunoEditado.Nome}?",
                    "Editar",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    EditarAluno editarAluno = new EditarAluno(this, alunoEditado);
                    editarAluno.Show();
                }
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            _principal.Alunos = alunosLista;
            _principal.UpdateLists();


        }
    }
}
