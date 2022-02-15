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
    public class EditarViewModel : BindableObject
    {
        public Aluno AlunoSelecionado;

        public ObservableCollection<Aluno> AlunoLista { get; set; }

        private Aluno _aluno;

        public EditarViewModel()
        {

        }
        public EditarViewModel(Aluno alunoSelecionado, ObservableCollection<Aluno> alunos)
        {
            this.AlunoSelecionado = alunoSelecionado;

            AlunoEditar = alunoSelecionado;

            AlunoLista = new ObservableCollection<Aluno>(alunos);

            _aluno = alunoSelecionado;

            AtualizarComando = new Command(Atualizar);
        }

        private void Atualizar(object obj)
        {

            _aluno.Nome = AlunoEditar.Nome;
            _aluno.Apelido = AlunoEditar.Apelido;
            MainVielModel.GetInstance().Atualizar(_aluno, AlunoLista);

            Application.Current.MainPage.Navigation.PopModalAsync();
        }


        public Aluno AlunoEditar
        {
            get => _aluno;
            set
            {
                _aluno = value;
                OnPropertyChanged();
            }
        }

        public Command AtualizarComando { get; set; }
    }
}
