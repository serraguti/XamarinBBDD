using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinBBDD.Dependencies;
using XamarinBBDD.Models;

namespace XamarinBBDD.Repositories
{
    public class RepositoryDepartamentos
    {
        SQLiteConnection cn;
        public RepositoryDepartamentos()
        {
            this.cn =
                DependencyService.Get<IDataBase>().GetConnection();
        }

        public void CrearBBDD()
        {
            this.cn.DropTable<Departamento>();
            this.cn.CreateTable<Departamento>();
        }

        public List<Departamento> GetDepartamentos()
        {
            var query =
                from datos in this.cn.Table<Departamento>()
                select datos;
            return query.ToList();
        }

        public Departamento FindDepartamento(int id)
        {
            var query = from datos in this.cn.Table<Departamento>()
                        where datos.IdDepartamento == id
                        select datos;
            return query.FirstOrDefault();
        }

        public void InsertarDepartamento(int id, String nombre
            , String localidad)
        {
            Departamento departamento = new Departamento();
            departamento.IdDepartamento = id;
            departamento.Nombre = nombre;
            departamento.Localidad = localidad;
            this.cn.Insert(departamento);
        }

        public void EliminarDepartamento(int id)
        {
            Departamento departamento =
                this.FindDepartamento(id);
            this.cn.Delete(departamento);
        }

        public void UpdateDepartamento(int id, String nombre
            , String localidad)
        {
            Departamento departamento = this.FindDepartamento(id);
            departamento.Nombre = nombre;
            departamento.Localidad = localidad;
            this.cn.Update(departamento);
        }
    }
}
