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
    public partial class AdicionarAlunoTurma : Form
    {
        List<Aluno> _alunos;
        public AdicionarAlunoTurma(List<Aluno> alunos)
        {
            InitializeComponent();
            _alunos = alunos;
        }

        public void AtualizarLista()
        {
            lbAlunos.Items.Clear();
            lbAlunos.DataSource = _alunos;
        }
    }
}
