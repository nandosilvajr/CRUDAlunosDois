using Biblioteca;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace XamarinAlunos.ViewModels
{
    public class EditarProfessorViewModel : BindableObject
    {
        public Professor ProfessorSelecionado;

        public ObservableCollection<Professor> ProfessorLista { get; set; }

        private Professor _professor;

        public EditarProfessorViewModel()
        {

        }
        public EditarProfessorViewModel(Professor professorSelecionado, ObservableCollection<Professor> professores)
        {
            this.ProfessorSelecionado = professorSelecionado;

            ProfessorEditar = professorSelecionado;

            ProfessorLista = new ObservableCollection<Professor>(professores);

            _professor = professorSelecionado;

            AtualizarProfessorComando = new Command(Atualizar);
        }

        private void Atualizar(object obj)
        {
            _professor.Nome = ProfessorEditar.Nome;
            _professor.Apelido = ProfessorEditar.Apelido;
            ProfessoresViewModel.GetInstance().Atualizar(_professor, ProfessorLista);
            Application.Current.MainPage.Navigation.PopModalAsync();
        }


        public Professor ProfessorEditar
        {
            get => _professor;
            set
            {
                _professor = value;
                OnPropertyChanged();
            }
        }

        public Command AtualizarProfessorComando { get; set; }
    }
}
