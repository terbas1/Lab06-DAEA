using Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace Semana05.ViewModel
{
    public class ListaViewModel : ViewModelBase
    {
        private readonly static ListaViewModel _instance = new ListaViewModel();


        public static ListaViewModel Instance
        {
            get
            {
                return _instance;
            }
        }

        public ObservableCollection<Categoria> _Categorias;
        public ObservableCollection<Categoria> Categorias
        {
            get { return _Categorias; }
            set
            {
                if (Categorias != value)
                {
                    _Categorias = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand NuevoCommand { get; set; }

        public ICommand ConsultarCommand { get; set; }



        private ListaViewModel()
        {
            Categorias = new Model.CategoriaModel().categorias;
            NuevoCommand = new RelayCommand<Window>(param => Abrir());
            ConsultarCommand = new RelayCommand<Window>(o => { Categorias = (new Model.CategoriaModel()).categorias; });

        }


        void Abrir()
        {
            ManCategoria window = new ManCategoria(new Categoria());
            window.Show();
        }
    }
}
