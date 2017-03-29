
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace FormsToMvvm.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _keyWord;
        private List<string> _sugestoes = new List<string>();
        private bool _isVisible;
        private List<string> _meusCortes = new List<string>();
        private string _corteSelecionado;
        public string CorteSelecionado
        {
            get
            { return _corteSelecionado; }
            set
            {
                _corteSelecionado = value;
                OnPropertyChanged();
            }
        }
        public string KeyWord
        {
            get { return _keyWord; }
            set
            {
                _keyWord = value;
                OnPropertyChanged();
            }
        }
        public List<string> Sugestoes
        {
            get { return _sugestoes; }
            set
            {
                _sugestoes = value;
                OnPropertyChanged();
            }
        }
        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                OnPropertyChanged();
            }
        }
        public Command FiltrarCommand
        {
            get
            {
                return new Command(Filtrar);
            }
        }
        public Command AdicionarCommand
        {
            get
            {
                return new Command(Adicionar);
            }
        }
        public List<string> MeusCortes
        {
            get
            {
                return _meusCortes;
            }
            set
            {
                _meusCortes = value;
                OnPropertyChanged();
            }
        }
        private List<string> cortes = new List<string>
        {
            "Social","Só máquina","Militar","Degradê","Surfista"
        };
        private void Filtrar()
        {
            if (_keyWord.Length >= 1)
            {
                Sugestoes = cortes.Where(c => c.ToLower().Contains(_keyWord.ToLower())).ToList();
                IsVisible = true;
            }
            else
            {
                IsVisible = false;
            }

        }
        private void Adicionar()
        {
            var c = _meusCortes;
            c.Add(_corteSelecionado);
            MeusCortes = c.ToList();
            IsVisible = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
