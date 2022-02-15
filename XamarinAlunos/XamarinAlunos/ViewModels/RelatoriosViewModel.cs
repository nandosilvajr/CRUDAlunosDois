using Biblioteca;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XamarinAlunos.ViewModels
{
    internal class RelatoriosViewModel : BindableObject
    {

        ObservableCollection<Turma> turmas = new ObservableCollection<Turma>();
        public ObservableCollection<Turma> TurmasMain
        {
            get
            {
                return turmas;
            }
            set
            {
                turmas = value;
                OnPropertyChanged();
            }
        }

        ObservableCollection<Aluno> alunos = new ObservableCollection<Aluno>();
        public ObservableCollection<Aluno> AlunoMain
        {
            get
            {
                return alunos;
            }
            set
            {
                alunos = value;
                OnPropertyChanged();
            }
        }

        ObservableCollection<Professor> professores = new ObservableCollection<Professor>();
        public ObservableCollection<Professor> ProfessorMain
        {
            get
            {
                return professores;
            }
            set
            {
                professores = value;
                OnPropertyChanged();
            }
        }

        Color _adicionarButtonColor = Color.DodgerBlue;

        public Color AdicionarButtonColor
        {
            get
            {
                return _adicionarButtonColor;

            }
            set
            {
                _adicionarButtonColor = value;
                OnPropertyChanged(nameof(AdicionarButtonColor));
            }

        }
        public RelatoriosViewModel()
        {



        }

    }
}
