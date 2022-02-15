using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAlunos
{
    public partial class Turmas : Form
    {
        int contaTurmas = 1;
        List<Professor> _professores;
        List<Aluno> _alunos;
        List<Turma> _turmas;

        List<Aluno> _alunoTransactions;
        List<Professor> _professorTransactions;


        public List<Turma> TurmasProfessorAluno { get => _turmas; set => _turmas = value; }
        public List<Aluno> AlunoTransactions { get => _alunoTransactions; set => _alunoTransactions = value; }
        public List<Professor> ProfessorTransactions { get => _professorTransactions; set => _professorTransactions = value; }

        public Turmas(List<Professor> professores, List<Aluno> alunos)
        {
            InitializeComponent();
            tbIdturma.Text = contaTurmas.ToString();
            _professores = new List<Professor>(professores);
            _alunos = new List<Aluno>(alunos);
            TurmasProfessorAluno = new List<Turma>();
            AlunoTransactions = new List<Aluno>();
            ProfessorTransactions = new List<Professor>();

            UpdateListas();

        }

        private void UpdateListas()
        {
            lbAlunos.DataSource = null;
            lbAlunos.DataSource = _alunos;

            lbProfessores.DataSource = null;
            lbProfessores.DataSource = _professores;

            lbAlunoTurma.DataSource = null;
            lbAlunoTurma.DataSource = AlunoTransactions;

            lbProfessorTurma.DataSource = null;
            lbProfessorTurma.DataSource = ProfessorTransactions;
        }

        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            AdicionarAlunoTurma adicionarAlunoTurma = new AdicionarAlunoTurma(_alunos);
            adicionarAlunoTurma.Show();
        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            if (lbAlunos.SelectedItems.Count == 0)
                MessageBox.Show("É necessário selecionar um aluno.");

            Aluno alunoAdicionar = lbAlunos.SelectedItem as Aluno;

            Aluno alunoAdicionado = null;

            if (alunoAdicionar != null)
            {
                foreach (Aluno al in _alunos)
                {
                    alunoAdicionado = al;
                }
            }
            if (alunoAdicionado != null)
            {

                _alunos.Remove(alunoAdicionado);
                AlunoTransactions.Add(alunoAdicionar);
                UpdateListas();
            }

        }
        private void btnRemoverAluno_Click(object sender, EventArgs e)
        {
            if (lbAlunoTurma.SelectedItems.Count == 0)
                MessageBox.Show("É necessário selecionar um aluno.");

            Aluno alunoRemover = lbAlunoTurma.SelectedItem as Aluno;

            Aluno alunoRemovido = null;

            if (alunoRemover != null)
            {
                foreach (Aluno al in AlunoTransactions)
                {
                    alunoRemovido = al;
                }
            }
            if (alunoRemovido != null)
            {
                AlunoTransactions.Remove(alunoRemover);
                _alunos.Add(alunoRemover);
                UpdateListas();
            }

        }
        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            if (lbProfessores.SelectedItems.Count == 0)
                MessageBox.Show("É necessário selecionar um professor.");

            Professor professorAdicionar = lbProfessores.SelectedItem as Professor;


            Professor professorAdicionado = null;

            if (professorAdicionar != null)
            {
                foreach (Professor pr in _professores)
                {
                    professorAdicionado = pr;
                }
            }
            if (professorAdicionado != null)
            {

                ProfessorTransactions.Add(professorAdicionar);
                _professores.Remove(professorAdicionar);
                UpdateListas();
            }



        }

        private void btnRemoverProfessor_Click(object sender, EventArgs e)
        {
            if (lbProfessorTurma.SelectedItems.Count == 0)
                MessageBox.Show("É necessário selecionar um professor.");

            Professor professorRemover = lbProfessorTurma.SelectedItem as Professor;



            Professor professorRemovido = null;

            if (professorRemover != null)
            {
                foreach (Professor pr in _professores)
                {
                    professorRemovido = pr;
                }
            }
            if (professorRemovido != null)
            {
                ProfessorTransactions.Remove(professorRemover);
                _professores.Add(professorRemover);
                UpdateListas();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lbProfessorTurma.Items.Count == 0 || lbAlunoTurma.Items.Count == 0)
            {
                MessageBox.Show("É necessário incluir pelo menos um professor e um aluno!");
            }
            TurmasProfessorAluno.Add(
                new Turma
                {
                    TurmaId = Convert.ToInt32(tbIdturma.Text),
                    Alunos = AlunoTransactions,
                    Professores = ProfessorTransactions
                });

            string resultado = string.Empty;

            foreach (Turma t in TurmasProfessorAluno)
            {
                resultado += "Turma N.:" + t.TurmaId + "\n";
                resultado += "Lista dos Alunos\n";

                foreach (Aluno aluno in t.Alunos)
                {
                    resultado+= aluno.Nome + "\n";
                }
                resultado += "Lista dos Professores\n";
                foreach (Professor professor in t.Professores)
                {
                   resultado += professor.Nome + "\n";
                }
            }
            MessageBox.Show(resultado);

            this.Close();
        }

    }
}
