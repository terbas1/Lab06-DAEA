using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BCategoria
    {
        private DCategoria dCategoria = null;

        public List<Categoria> Get()
        {

            List<Categoria> categoriaList = null;

            try
            {
                dCategoria = new DCategoria();
                categoriaList = dCategoria.Get();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return categoriaList;
        }

        public bool Insert(Categoria categoria)
        {
            try
            {
                dCategoria = new DCategoria();
                categoria.IdCategoria = dCategoria.Get().Max(x => x.IdCategoria) + 1;
                dCategoria.Insert(categoria);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Categoria categoria)
        {

            try
            {
                dCategoria = new DCategoria();
                dCategoria.Update(categoria);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Delete(int idcategoria)
        {
            try
            {
                dCategoria = new DCategoria();
                dCategoria.Delete(idcategoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
