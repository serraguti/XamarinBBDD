using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinBBDD.Repositories;
using XamarinBBDD.ViewModels;

namespace XamarinBBDD.Services
{
    public class ServiceIoC
    {
        private IContainer container;

        public ServiceIoC()
        {
            this.RegisterDependencies();
        }

        private void RegisterDependencies()
        {
            ContainerBuilder builder = new ContainerBuilder();
            //REGISTRAMOS TODAS LAS CLASES QUE TENGAN
            //INYECCION DE DEPENDENCIAS
            builder.RegisterType<RepositoryPersonajes>();
            builder.RegisterType<PersonajesViewModel>();
            //CREAMOS EL CONTENEDOR
            this.container = builder.Build();
        }
    }
}
