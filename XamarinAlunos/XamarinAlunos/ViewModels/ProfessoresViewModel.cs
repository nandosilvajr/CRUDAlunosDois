using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Biblioteca;
using Xamarin.Forms;

namespace XamarinAlunos.ViewModels
{
    public class ProfessoresViewModel : BindableObject
    {
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

        private static ProfessoresViewModel instance;
        public ProfessoresViewModel()
        {
            instance = this;

            Adicionar = new Command(AdicionarNomes);

            RemoverProfessorIndexComando = new Command<string>(RemoverProfessorIndex);


            EditarNavCommand = new Command(async () =>
            {
                var editarPageVM = new EditarProfessorViewModel(ProfessorSelecionado, ProfessorMain);

                var editarPage = new EditarProfessor();

                editarPage.BindingContext = editarPageVM;

                await Application.Current.MainPage.Navigation.PushModalAsync(editarPage);

            });
        }

        public static ProfessoresViewModel GetInstance()
        {
            if (instance == null)
                return new ProfessoresViewModel();

            return instance;
        }

        public void Atualizar(object obj, ObservableCollection<Professor> professorEditar)
        {

            professores.Clear();

            Professor professorEditado = (Professor)obj;

            var item = professorEditar.FirstOrDefault(x => x.ProfessorId == professorEditado.ProfessorId);

            if (item != null)
            {
                item.Nome = professorEditado.Nome;
                item.Apelido = professorEditado.Apelido;
            }
            foreach (Professor p in professorEditar)
            {
                professores.Add(p);
            }
        }
        public Command EditarNavCommand { get; set; }

        Professor _professor;
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

        private Command RemoverProfessorIndexComando;
        private void RemoverProfessorIndex(string obj)
        {
            var item = professores.Where(professor => professor.ProfessorId == Convert.ToInt32(obj)).FirstOrDefault();
            professores.Remove(item);
        }


        private Command _removerProfessor;

        public Command RemoverProfessor
        {
            get { return _removerProfessor = new Command(RemoverProfessorComando); }
        }

        private void RemoverProfessorComando(object obj)
        {
            professores.Remove(ProfessorSelecionado);
        }

     
        string _professorNome;

        int _professorId = 1;

        string _professorApelido;

        public string ProfessorNome
        {
            get
            {
                return _professorNome;
            }
            set
            {
                _professorNome = value;
                OnPropertyChanged();
            }
        }
        public int ProfessorId { get => _professorId; set { _professorId = value; OnPropertyChanged(); } }
        public string ProfessorApelido { get => _professorApelido; set { _professorApelido = value; OnPropertyChanged(); } }

        private Professor _professorSelecionado;
        public Professor ProfessorSelecionado
        {
            get => _professorSelecionado;
            set
            {
                _professorSelecionado = value;
                OnPropertyChanged();
            }

        }
        private void AdicionarNomes(object obj)
        {
            professores.Add(new Biblioteca.Professor
            {
                ProfessorId = ProfessorId,
                Nome = ProfessorNome,
                Apelido = ProfessorApelido
            });

            ProfessorId++;
            ProfessorNome = string.Empty;
            ProfessorApelido = string.Empty;
        }
        public Command Adicionar { get; set; }

    }
}
