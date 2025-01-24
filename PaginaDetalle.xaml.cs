namespace Practica;

public partial class PaginaDetalle : ContentPage
{
    private bool EstaEditado = true;

    public PaginaDetalle(Publicacion publicacion)
    {
        InitializeComponent();
        BindingContext = publicacion;
        TipoPicker.SelectedItem = publicacion.Tipo.ToString();
        EstadoPicker.SelectedItem = publicacion.Estado.ToString();
    }

    private void Volver(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void ModoEditar(object sender, EventArgs e)
    {
        if (EstaEditado)
        {
            // Save changes
            AutorizarEditar();
            BotonEditarGuardar.Text = "Guardar";
        }
        else
        {
            // Enable editing
            GuardarCambios();
            BotonEditarGuardar.Text = "Editar";

        }
        EstaEditado = !EstaEditado;
    }


    private void AutorizarEditar()
    {
        
        TipoPicker.IsEnabled = true;
        EstadoPicker.IsEnabled = true;

        //change background color
        TipoPicker.BackgroundColor = Color.FromRgb(255, 165, 0);
        EstadoPicker.BackgroundColor = Color.FromRgb(255, 165, 0);

    }

    private void GuardarCambios()
    {
        TipoPicker.IsEnabled = false;
        EstadoPicker.IsEnabled = false;
        
        //change background color
        TipoPicker.BackgroundColor = Color.FromRgb(255, 255, 255);
        EstadoPicker.BackgroundColor = Color.FromRgb(255, 255, 255);

        // It already updates, since is a observableObject and is on Binding context ^.^
        DisplayAlert("Guardar", "Los cambios han sido guardados.", "OK");
    }



    private void AñadirAutor(object sender, EventArgs e)
    {
        var publicacion = BindingContext as Publicacion;
        if (publicacion != null)
        {

            if (AutoresNuevosEntry.Text == string.Empty)
            {
                DisplayAlert("Error", "El autor es obligatorio.", "OK");
                return;
            }

            publicacion.Autores.Add(AutoresNuevosEntry.Text);
            AutoresNuevosEntry.Text = string.Empty;
        }
    }



    private void Eliminar(object sender, EventArgs e)
    {
        var publicacion = BindingContext as Publicacion;
        if (publicacion != null)
        {
            ListaPublicacion.Eliminar(publicacion.Titulo);
            Navigation.PopAsync();
        }
    }

}
