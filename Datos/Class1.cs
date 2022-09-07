using Datos.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Class1
    {
        private static NorthWindTuneadoDbContext _db = null;

        public Class1()
        {
            if (_db == null)
            {
                _db = new NorthWindTuneadoDbContext();
            }
        }

        public IList<Categoria> DevuelveCategorias()
        {
            IList<Categoria> categorias = null;
            categorias = _db.Categoria.ToList();

            return categorias;
        }

        public bool GuardarRegistro(Categoria categoria)
        {
            bool ok = false;
            try
            {
                _db.Categoria.Add(categoria);
                int respuesta = 0;
                respuesta = _db.SaveChanges();
                if (respuesta > 0)
                {
                    ok = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        public bool GuardarRegistro(int id, string texto)
        {
            bool ok = false;
            Categoria categoria = null;
            //categoria = _db.Categoria.Find(id);
            categoria = _db.Categoria.Where(x => x.CategoryID == id).FirstOrDefault();
            categoria.CategoryName = texto;
            try
            {
                int respuesta = 0;
                respuesta = _db.SaveChanges();
                if (respuesta > 0)
                {
                    ok = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        public bool GuardarRegistro(int id)
        {
            bool ok = false;
            Categoria categoria = null;
            categoria = _db.Categoria.Where(x => x.CategoryID == id).FirstOrDefault();
            _db.Categoria.Remove(categoria);
            try
            {
                int respuesta = 0;
                respuesta = _db.SaveChanges();
                if (respuesta > 0)
                {
                    ok = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        public bool GuardarRegistro(string texto)
        {
            bool ok = false;
            IList<Categoria> categorias = null;
            categorias = _db.Categoria.Where(x => x.CategoryName == texto).ToList();
            foreach (var categoria in categorias)
            {
                _db.Categoria.Remove(categoria);
            }

            try
            {
                int respuesta = 0;
                respuesta = _db.SaveChanges();
                if (respuesta > 0)
                {
                    ok = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

    }
}
