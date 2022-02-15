using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAlunos
{
    public partial class Principal : Form
    {

        List<Professor> _professores;
        List<Aluno> _alunos;

        public Form1 Form1 { get; set; }
        public Professores ProfessoresForm { get; set; }
        public List<Professor> Professores { get => _professores; set => _professores = value; }
        public List<Aluno> Alunos { get => _alunos; set => _alunos = value; }

        public Principal()
        {
            InitializeComponent();
            UpdateLists();

        }

        public void UpdateLists()
        {


            if (Professores == null)
            {
                Professores = new List<Professor>();
            }
            if (Alunos == null)
            {
                Alunos = new List<Aluno>();
            }

            if (Professores.Count > 0 && Alunos.Count > 0)
            {
                btnTurmas.Enabled = true;
            }

            Debug.WriteLine(Professores.Count + "Quantidade de Professores");
            Debug.WriteLine(Alunos.Count + "Quantidade de Alunos");

        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            Professores professoreForm = new Professores(this);

            professoreForm.ShowDialog();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.ShowDialog();
        }

        private void btnTurmas_Click(object sender, EventArgs e)
        {
            Turmas turmas = new Turmas(Professores, Alunos);
            turmas.Show();
        }
    }
}
