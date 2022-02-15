using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAlunos
{
    public partial class Professores : Form
    {

        int contaProfessores = 1;
        public List<Professor> professoresLista;

        Principal _principal;
        
        public Professores(Principal principal)
        {
            InitializeComponent();
            professoresLista = new List<Professor>();
            tbIdProfessor.Text = contaProfessores.ToString();
            _principal = principal;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Professor professor;

            if (ValidaForm())
            {
                professor = new Professor
                {
                    ProfessorId = contaProfessores,
                    Nome = tbNome.Text,
                    Apelido = tbApelido.Text
                };

                professoresLista.Add(professor);
                contaProfessores++;
                tbIdProfessor.Text = contaProfessores.ToString();
                populaLista();
            }
            else
            {
                MessageBox.Show("É necessário preencher as informações dos alunos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            tbNome.Text = string.Empty;
            tbApelido.Text = string.Empty;
        }

        public void populaLista()
        {
            lbProfessores.DataSource = null;
            lbProfessores.DataSource = professoresLista.ToList();
            lbProfessores.DisplayMember = "NomeCompleto";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbNome.Text = string.Empty;
            tbApelido.Text = string.Empty;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Professor professorApagar = lbProfessores.SelectedItem as Professor;

            Professor professorApagado = null;

            if (professorApagar != null)
            {
                foreach (Professor pr in professoresLista)
                {
                    if (pr.ProfessorId == professorApagar.ProfessorId)
                    {
                        professorApagado = pr;
                    }
                }
            }
            if (professorApagado != null)
            {
                DialogResult result;
                result = MessageBox.Show($"Tem certeza que deseja apagar o aluno {professorApagado.Nome}?",
                    "Apagar",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    professoresLista.Remove(professorApagado);
                    populaLista();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Professor professorEditar = lbProfessores.SelectedItem as Professor;

            Professor professorEditado = null;

            if (professorEditar != null)
            {
                foreach (Professor pr in professoresLista)
                {
                    if (pr.ProfessorId == professorEditar.ProfessorId)
                    {
                        professorEditado = pr;
                    }
                }
            }
            if (professorEditado != null)
            {
                DialogResult result;
                result = MessageBox.Show($"Tem certeza que deseja editar o aluno {professorEditado.Nome}?",
                    "Editar",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    EditarProfessor editarAluno = new EditarProfessor(this, professorEditado);
                    editarAluno.Show();
                }
            }
        }

        private void Professores_FormClosed(object sender, FormClosedEventArgs e)
        {
            _principal.Professores = professoresLista;
            _principal.UpdateLists();
        }
    }
}
