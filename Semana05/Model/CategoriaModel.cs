using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana05.Model
{
    public class CategoriaModel
    {
        public ObservableCollection<Categoria> categorias { get; set; }

        public CategoriaModel()
        {
            var lista = (new BCategoria()).Get();
            categorias = new ObservableCollection<Categoria>(lista);
        }

        public bool Insertar(Categoria categoria)
        {
            return (new BCategoria()).Insert(categoria);
        }

        public bool Actualizar(Categoria categoria)
        {
            return (new BCategoria()).Update(categoria);
        }
        

    }


}
