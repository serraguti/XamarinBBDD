using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinBBDD.Base;
using XamarinBBDD.Models;
using XamarinBBDD.Repositories;

namespace XamarinBBDD.ViewModels
{
    public class PersonajeViewModel: ViewModelBase
    {
        RepositoryPersonajes repo;

        public PersonajeViewModel()
        {
            this.repo = new RepositoryPersonajes();
            this.Personaje = new Personaje();
        }

        private Personaje _Personaje;
        public Personaje Personaje
        {
            get { return this._Personaje; }
            set
            {
                this._Personaje = value;
                OnPropertyChanged("Personaje");
            }
        }

        public Command Insertar
        {
            get
            {
                return new Command(() => {
                    this.repo.InsertarPersonaje
                    (this.Personaje.Nombre, this.Personaje.Serie);
                });
            }
        }

        public Command Modificar
        {
            get
            {
                return new Command(() => {
                    this.repo.UpdatePersonaje
                    (this.Personaje.IdPersonaje, this.Personaje.Nombre
                    , this.Personaje.Serie);
                });
            }
        }

        public Command Eliminar
        {
            get
            {
                return new Command(() => {
                    this.repo.DeletePersonaje
                    (this.Personaje.IdPersonaje);
                });
            }
        }
    }
}
