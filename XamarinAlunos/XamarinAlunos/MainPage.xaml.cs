using Biblioteca;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinAlunos.ViewModels;

namespace XamarinAlunos
{
    public partial class MainPage : TabbedPage
    {
        public ObservableCollection<Aluno> alunos { get; set; }
        public ObservableCollection<Professor> professores { get; set; }

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainVielModel();
        }

        protected override void OnCurrentPageChanged()
        {
            
            base.OnCurrentPageChanged();
            if (CurrentPage is MainPage)
            {

                
            }
            else if (CurrentPage is Professores)
            {

                
            }
            else if (CurrentPage is Turmas)
            {
               
               
               var viewModel = CurrentPage.BindingContext as TurmaViewModel;
                viewModel.AlunoMain = MainVielModel.GetInstance().AlunoMain;

                viewModel.ProfessorMain = ProfessoresViewModel.GetInstance().ProfessorMain;


            }

            else if (CurrentPage is Relatorios)
            {

                var viewModel = CurrentPage.BindingContext as RelatoriosViewModel;
                viewModel.TurmasMain = new ObservableCollection<Turma>(TurmaViewModel.GetInstance().TurmasMain);
   
            }
            // Same for other pages
        }
    }
}
