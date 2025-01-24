namespace Practica;

public partial class PaginaPublicaciones : ContentPage
{
    public PaginaPublicaciones()
    {

        InitializeComponent();
        ListaPublicaciones.ItemsSource = ListaPublicacion.Publicaciones;
        
    }

    private void FiltrarPorAutor(object sender, EventArgs e)
    {
        try
        {
            var autor = AutorEntry.Text?.Trim();

            if (string.IsNullOrEmpty(autor))
            {
                ListaPublicaciones.ItemsSource = ListaPublicacion.Publicaciones; // Vuelve a todas las publicaciones
                return;
            }

            var publicacionesAutor = ListaPublicacion.FiltrarPorAutor(autor);
            DisplayAlert("Filtrado", $"Se encontraron {publicacionesAutor.Count} publicaciones para el autor.", "OK");
            
            ListaPublicaciones.ItemsSource = publicacionesAutor; // Actualiza la lista de publicaciones


        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"Ocurrio un error al filtrar por autor: {ex.Message}", "OK");
        }
    }


    private void FiltrarPorTipo(object sender, EventArgs e)
    {
        try
        {
            if (TipoPicker.SelectedItem == null)
            {
                DisplayAlert("Error", "Por favor, selecciona un tipo.", "OK");
                return;
            }

            var tipo = (TipoPublicacion)Enum.Parse(typeof(TipoPublicacion), TipoPicker.SelectedItem.ToString());

            var publicacionesFiltradas = ListaPublicacion.FiltrarPorTipo(tipo);

            DisplayAlert("Filtrado", $"Se encontraron {publicacionesFiltradas.Count} publicaciones.", "OK");

            
            ListaPublicaciones.ItemsSource = publicacionesFiltradas;
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"Ocurrio un error al filtrar por tipo: {ex.Message}", "OK");
        }
    }


    private async void VerDetalles(object sender, EventArgs e)
    {
        var publicacion = (sender as Button)?.BindingContext as Publicacion;
        if (publicacion != null)
        {
            await Navigation.PushAsync(new PaginaDetalle(publicacion));
        }
    }
}



