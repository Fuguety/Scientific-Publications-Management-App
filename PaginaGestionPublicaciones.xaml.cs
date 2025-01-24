using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Practica
{
    public partial class PaginaGestionPublicaciones : ContentPage
    {
        public PaginaGestionPublicaciones()
        {
            InitializeComponent();
        }

        private async void AgregarPublicacion(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado un tipo y un estado

                if (TipoPicker.SelectedItem == null || EstadoPicker.SelectedItem == null)
                {
                    await DisplayAlert("Error", "Por favor, selecciona un tipo y un estado antes de continuar.", "OK");
                    return;
                }


                var nuevaPublicacion = new Publicacion(
                    id: int.Parse(IdEntry.Text),
                    titulo: TituloEntry.Text,
                    fechaPublicacion: FechaPicker.Date,
                    tipo: (TipoPublicacion)Enum.Parse(typeof(TipoPublicacion), TipoPicker.SelectedItem.ToString()),
                    estado: (EstadoPublicacion)Enum.Parse(typeof(EstadoPublicacion), EstadoPicker.SelectedItem.ToString())

                )
                {
                    
                    /*
                    La línea de código asigna a la variable Autores una colección observable (ObservableCollection<string>). 
                    Si el texto en AutoresEntry.Text está vacío, es null o contiene solo espacios en blanco, se asigna una colección vacía. 
                    De lo contrario, divide el texto en partes separadas por comas, elimina los espacios extra de cada parte y crea una colección con los resultados. 
                    Es una forma compacta de manejar entradas de texto que representan una lista de autores.

                    El uso de ? y : corresponde al operador condicional ternario en C#. Este operador es una forma compacta de escribir una estructura if-else. 
                    Se utiliza para evaluar una condición y devolver uno de dos valores según si la condición es true o false.

                    Fue aporte y sugerencia de Lucas, que quería prácticar la utilización de nuevos operadores en C#.

                    En el exámen nos adaptaremos a lo visto en clase.

                    */
                    Autores = string.IsNullOrWhiteSpace(AutoresEntry.Text)
                            ? new ObservableCollection<string>()
                            : new ObservableCollection<string>(AutoresEntry.Text.Split(',').Select(a => a.Trim()))

                           
                };


                Debug.WriteLine($"Nueva publicacion: {nuevaPublicacion.Autores}");

                if (ComprobarErrores(sender, e, nuevaPublicacion))
                {
                    ListaPublicacion.Agregar(nuevaPublicacion);
                    DisplayAlert("Éxito", "Publicacion agregada correctamente", "OK");
                }


            }
            catch (Exception ex)
            {
                DisplayAlert("Error", $"Ocurrio un error al agregar la publicacion: {ex.Message}", "OK");
            }
        }






        private bool ComprobarErrores(object sender, EventArgs e, Publicacion publicacion)
        {
            if (ListaPublicacion.Existe(publicacion.Id))
            {
                DisplayAlert("Error", "Ya existe una publicación con el mismo ID.", "OK");
                return false;
            }

            if (ListaPublicacion.Existe(publicacion.Titulo))
            {
                DisplayAlert("Error", "Ya existe una publicación con el mismo título.", "OK");
                return false;
            }

            if (string.IsNullOrEmpty(publicacion.Titulo))
            {
                DisplayAlert("Error", "El títutlo de la publicación es obligatorio.", "OK");
                return false;
            }

            if (publicacion.Autores == null || publicacion.Autores.Count == 0)
            {
                DisplayAlert("Error", "La publicación debe tener al menos un autor.", "OK");
                return false;
            }



            return true;
        }

    }
}
