using Biblioteca;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinAlunos.ViewModels
{
    public class MainVielModel : BindableObject
    {
        ObservableCollection<Aluno> alunos = new ObservableCollection<Aluno>();
        public ObservableCollection<Aluno> AlunoMain { 
            get { 
                return alunos; 
            } 
            set {
                alunos = value;
                OnPropertyChanged();
            } 
        }

        private static MainVielModel instance;


        public MainVielModel()
        {


            instance = this;

            Adicionar = new Command(AdicionarNomes);

            RemoverAlunoIndexComando = new Command<string>(RemoverAlunoIndex);

       
            EditarNavCommand = new Command(async () =>
            {
                var editarPageVM = new EditarViewModel(AlunoSelecionado, AlunoMain);

                var editarPage = new Editar();

                editarPage.BindingContext = editarPageVM;

                await Application.Current.MainPage.Navigation.PushModalAsync(editarPage);

            });
        }

        public static MainVielModel GetInstance()
        {
            if(instance == null)
                return new MainVielModel();

            return instance;
        }

        public void Atualizar(object obj, ObservableCollection<Aluno> alunosEditar)
        {

            alunos.Clear();

            Aluno alunoEditado = (Aluno)obj;

            var item = alunosEditar.FirstOrDefault(x=> x.AlunoId == alunoEditado.AlunoId);
           
            if(item != null)
            {
                item.Nome = alunoEditado.Nome;
                item.Apelido = alunoEditado.Apelido;
            }
            foreach(Aluno aluno in alunosEditar)
            {
                alunos.Add(aluno);
            }
        }
        public Command EditarNavCommand { get; set; }


        Aluno _aluno;
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
        
        private Command RemoverAlunoIndexComando;
        private void RemoverAlunoIndex(string obj)
        {
            var item = alunos.Where(aluno => aluno.AlunoId == Convert.ToInt32(obj)).FirstOrDefault();
            alunos.Remove(item);
        }

    
        string _alunonome;

        int _alunoId = 1;

        string _alunoApelido;


        private Command _removerAluno;

        public Command RemoverAluno
        {
            get { return _removerAluno = new Command(RemoverAlunoComando); }
        }

        private void RemoverAlunoComando(object obj)
        {
            alunos.Remove(AlunoSelecionado);
        }
        public string AlunoNome
        {
            get
            {
                return _alunonome;
            }
            set
            {
                _alunonome = value;
                OnPropertyChanged();
            }
        }
        public int AlunoId { get => _alunoId; set { _alunoId = value; OnPropertyChanged(); } }
        public string AlunoApelido { get => _alunoApelido; set { _alunoApelido = value; OnPropertyChanged(); } }

        private Aluno _alunoSelecionado;
        public Aluno AlunoSelecionado
        {
            get => _alunoSelecionado;
            set
            {
                _alunoSelecionado = value;
                OnPropertyChanged();

            }

        }
        private void AdicionarNomes(object obj)
        {
            alunos.Add(new Biblioteca.Aluno
            {
                AlunoId = AlunoId,
                Nome = AlunoNome,
                Apelido = AlunoApelido
            });

            AlunoId++;
            AlunoNome = string.Empty;
            AlunoApelido = string.Empty;
        }
        public Command Adicionar { get; set; }

    }
}
