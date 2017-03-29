using FormsToMvvm.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace FormsToMvvm
{
    public partial class MainPage : ContentPage
    {
        //private List<string> cortes = new List<string>
        //{
        //    "Social","Só máquina","Militar","Degradê","Surfista"
        //};
        //private ObservableCollection<string> meus_cortes = new ObservableCollection<string>();
        public MainPage()
        {
            InitializeComponent();
            //    BindingContext = new MainViewModel();
        }

        private void SelecionarCorte(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as MainViewModel;
            vm.AdicionarCommand.Execute(null);
            //var corteSelecionado = e.Item as string;
            //meus_cortes.Add(corteSelecionado);
            //lstCortes.ItemsSource = meus_cortes;
            //lst_sugestao_cortes.IsVisible = false;
        }

    }
}
