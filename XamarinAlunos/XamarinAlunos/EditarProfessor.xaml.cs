using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAlunos.ViewModels;

namespace XamarinAlunos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditarProfessor : ContentPage
    {
        public EditarProfessor()
        {
            InitializeComponent();
            this.BindingContext = new ProfessoresViewModel();
        }
    }
}