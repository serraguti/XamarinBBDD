using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinBBDD.Repositories;

namespace XamarinBBDD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainDepartamentos : ContentPage
    {
        RepositoryDepartamentos repo;
        public MainDepartamentos()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.botoncrear.Clicked += Botoncrear_Clicked;
            this.botoneliminar.Clicked += Botoneliminar_Clicked;
            this.botoninsertar.Clicked += Botoninsertar_Clicked;
            this.botonmodificar.Clicked += Botonmodificar_Clicked;
            this.botonmostrar.Clicked += Botonmostrar_Clicked;
        }

        private void Botoncrear_Clicked(object sender, EventArgs e)
        {
            this.repo.CrearBBDD();
            this.labelMensaje.Text = "BBDD creada";
        }

        private void Botoninsertar_Clicked(object sender, EventArgs e)
        {
            int id = int.Parse(this.cajaid.Text);
            this.repo.InsertarDepartamento(id,
                cajanombre.Text, cajalocalidad.Text);
            this.labelMensaje.Text = "Insertado";
        }

        private void Botonmostrar_Clicked(object sender, EventArgs e)
        {
            DepartamentosView view = new DepartamentosView();
            Navigation.PushModalAsync(view);
        }

        private void Botonmodificar_Clicked(object sender, EventArgs e)
        {
            int id = int.Parse(this.cajaid.Text);
            this.repo.UpdateDepartamento(id
                , cajanombre.Text, cajalocalidad.Text);
            this.labelMensaje.Text = "Modificado";
        }

        private void Botoneliminar_Clicked(object sender, EventArgs e)
        {
            int id = int.Parse(this.cajaid.Text);
            this.repo.EliminarDepartamento(id);
            this.labelMensaje.Text = "Eliminado";
        }
    }
}