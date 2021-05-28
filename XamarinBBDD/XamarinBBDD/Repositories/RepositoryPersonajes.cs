using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinBBDD.Models;

namespace XamarinBBDD.Repositories
{
    public class RepositoryPersonajes
    {
        private Realm realmConnection;

        public RepositoryPersonajes()
        {
            this.realmConnection = Realm.GetInstance();
        }

        public List<Personaje> GetPersonajes()
        {
            List<Personaje> personajes =
                this.realmConnection.All<Personaje>().ToList();
            return personajes;
        }

        public Personaje FindPersonaje(int id)
        {
            Personaje personaje =
                this.GetPersonajes()
                .FirstOrDefault(z => z.IdPersonaje == id);
            return personaje;
        }

        private int GetMaxId()
        {
            return this.GetPersonajes().Count + 1;
        }

        public void InsertarPersonaje(String nombre
            , String serie)
        {
            using (Transaction transaction =
                this.realmConnection.BeginWrite())
            {
                Personaje personaje = new Personaje();
                personaje.IdPersonaje = this.GetMaxId();
                personaje.Nombre = nombre;
                personaje.Serie = serie;
                transaction.Commit();
            }
        }

        public void UpdatePersonaje(int id, String nombre
            , String serie)
        {
            Personaje personaje = this.FindPersonaje(id);
            using (Transaction transaction =
                this.realmConnection.BeginWrite())
            {
                personaje.Nombre = nombre;
                personaje.Serie = serie;
                transaction.Commit();
            }
        }

        public void DeletePersonaje(int id)
        {
            Personaje personaje = this.FindPersonaje(id);
            using (Transaction transaction =
                this.realmConnection.BeginWrite())
            {
                this.realmConnection.Remove(personaje);
                transaction.Commit();
            }
        }
    }
}
