using System;
using System.Linq;
using RegistroPrestamo.DAL;
using RegistroPrestamo.Models;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RegistroPrestamo.BLL
{
    public class PrestamoBLL
    {
        public static bool Guardar(Prestamo prestamo)
        {
            if(!Existe(prestamo.PrestamoId))
                return Insertar(prestamo);
            else
                return Modificar(prestamo);
            
        }

        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Prestamo.Any(p => p.PrestamoId == id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        private static bool Insertar(Prestamo prestamo)
        {
            Contexto contexto = new Contexto();
            bool insertado = false;

            try
            {
                contexto.Prestamo.Add(prestamo);
                insertado = (contexto.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return insertado;
        }

        private static bool Modificar(Prestamo prestamo)
        {
            Contexto contexto = new Contexto();
            bool modificado = false;

            try
            {
                contexto.Entry(prestamo).State = EntityState.Modified;
                modificado = (contexto.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return modificado;
        }

        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool eliminado = false;

            try
            {
                var buscando = contexto.Prestamo.Find(id);
                contexto.Entry(buscando).State = EntityState.Deleted;
                eliminado = (contexto.SaveChanges() > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return eliminado;
        }

        public static Prestamo Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Prestamo prestamo = new Prestamo();

            try
            {
                prestamo = contexto.Prestamo.Find(id);
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return prestamo;
        }


        public static List<Prestamo> GetList(Expression<Func<Prestamo, bool>> prestamo)
        {
            Contexto contexto = new Contexto();
            List<Prestamo> listado = new List<Prestamo>();

            try
            {
                listado = contexto.Prestamo.Where(prestamo).ToList();
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return listado;
        }
    }
}