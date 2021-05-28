using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinBBDD.Base;
using XamarinBBDD.Models;
using XamarinBBDD.Repositories;
using XamarinBBDD.Views;

namespace XamarinBBDD.ViewModels
{
    public class PersonajesViewModel: ViewModelBase
    {
        RepositoryPersonajes repo;

        public PersonajesViewModel(RepositoryPersonajes repo)
        {
            this.repo = repo;
            this.LoadPersonajes();
        }

        public void LoadPersonajes()
        {
            List<Personaje> lista = this.repo.GetPersonajes();
            this.Personajes =
                new ObservableCollection<Personaje>(lista);
        }

        private ObservableCollection<Personaje> _Personajes;
        public ObservableCollection<Personaje> Personajes
        {
            get { return this._Personajes; }
            set
            {
                this._Personajes = value;
                OnPropertyChanged("Personajes");
            }
        }

        public Command Edicion
        {
            get
            {
                return new Command(() => {
PersonajesEdicion view = new PersonajesEdicion();
Application.Current.MainPage.Navigation.PushModalAsync(view);               
                });
            }
        }

        public Command CargarPersonajes
        {
            get
            {
                return new Command(() => {
                    List<Personaje> lista = 
                    this.repo.GetPersonajes();
                    this.Personajes =
                    new ObservableCollection<Personaje>(lista);
                });
            }
        }
    }
}
