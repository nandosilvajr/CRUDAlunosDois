using Biblioteca;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinAlunos.ViewModels
{

    public class TurmaViewModel : BindableObject
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

        ObservableCollection<Aluno> alunosTransaction = new ObservableCollection<Aluno>();
        public ObservableCollection<Aluno> AlunosTransaction
        {
            get
            {
                return alunosTransaction;
            }
            set
            {
                alunosTransaction = value;
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

        ObservableCollection<Professor> professoresTransactions = new ObservableCollection<Professor>();
        public ObservableCollection<Professor> ProfessorTransaction
        {
            get
            {
                return professoresTransactions;
            }
            set
            {
                professores = value;
                OnPropertyChanged();
            }
        }

        public static TurmaViewModel instance;

        public Command CriarTurmaComando { get; }
        public Command<string> AdicionarProfessor { get; set; }
        public Command<string> RemoverTurmaIndexComando { get; }
        public Command EditarNavCommand { get; }

        bool _adicionarEnable = true;

        Color _adicionarButtonColor = Color.DodgerBlue;

        public TurmaViewModel()
        {

            instance = this;

            CriarTurmaComando = new Command(AdicionarNomes);

            EditarNavCommand = new Command(async () =>
            {
                var editarPageVM = new EditarTurmaViewModel(TurmaSelecionada, TurmasMain);

                var editarPage = new EditarProfessor();

                editarPage.BindingContext = editarPageVM;

                await Application.Current.MainPage.Navigation.PushModalAsync(editarPage);

            });
        }

        public static TurmaViewModel GetInstance()
        {
            if (instance == null)
                return new TurmaViewModel();

            return instance;
        }

        private void AdicionarNomes(object obj)
        {
            

            int _turmaId = TurmasMain.Count() + 1;
            turmas.Add(new Turma
            {
                TurmaId = _turmaId,
                Alunos = AlunosTransaction.ToList(),
                Professores = ProfessorTransaction.ToList(),

            });

            AlunosTransaction.Clear();
            ProfessorTransaction.Clear();
        }

        private Turmas _turmaSelecionada;
        public Turmas TurmaSelecionada
        {
            get => _turmaSelecionada;
            set
            {
                _turmaSelecionada = value;
                OnPropertyChanged();
            }

        }


        public ICommand AdicionarProfessorComando
        {
            get
            {

                return new Command((e) =>
                   {
                       var item = e as Professor;

                       if (!ProfessorTransaction.Contains(item))
                       {

                           ProfessorTransaction.Add(item);

                       }
                       else
                       {
                          var res = Application.Current.MainPage.DisplayAlert("Atenção", $"O professor {item.NomeCompleto} já foi adicionado à turma", "Ok", "Cancel");
                          
                       }
                   }
                );
            }

        }

        public ICommand RemoverProfessorTurmaComando
        {
            get
            {
                return new Command(async (e) =>
                {
                    var item = e as Professor;

                    if (ProfessorTransaction.Contains(item))
                    {
                        var res = await Application.Current.MainPage.DisplayAlert("Atenção", $"Pretende remover o professor {item.NomeCompleto} da turma?", "Sim", "Não");

                        if (res) { 
                            ProfessorTransaction.Remove(item);
                        }
                    }
                });
            }

        }

        public ICommand AdicionarAlunoComando
        {
            get
            {
                return new Command((e) =>
                {
                    var item = e as Aluno;

                    if (!AlunosTransaction.Contains(item))
                    {
                        AlunosTransaction.Add(item);
                        
                    }
                    else
                    {
                        var res = Application.Current.MainPage.DisplayAlert("Atenção", $"O Aluno {item.NomeCompleto} já foi adicionado à turma", "Ok", "Cancel");
                    }
                }
                );
            }

        }
        public ICommand RemoverAlunoTurmaComando
        {
            get
            {
                return new Command(async (e) =>
                {
                    var item = e as Aluno;

                    if (AlunosTransaction.Contains(item))
                    {
                        var res = await Application.Current.MainPage.DisplayAlert("Atenção", $"Pretende remover o aluno {item.NomeCompleto} da turma?", "Sim", "Não");

                        if (res) { 
                            AlunosTransaction.Remove(item);
                        } 

                    }
                });
            }

        }

       
        string _alunoNome;
        public string AlunoNome
        {
            get
            {
                return _alunoNome;
            }
            set
            {
                _alunoNome = value;
                OnPropertyChanged();
            }
        }

        public bool AdicionarEnable { get => _adicionarEnable; set => _adicionarEnable = value; }
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
    }
}
