using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Practica;

public static class ListaPublicacion
{
    public static ObservableCollection<Publicacion> Publicaciones { get; set; } = new ObservableCollection<Publicacion>();


 
    public static void Agregar(Publicacion publicacion)
    {
        if (!Publicaciones.Any(p => p.Id == publicacion.Id))
        {
            Publicaciones.Add(publicacion);
        }
    }

    public static void AgregarAutor(int id, string autor)
    {
        var publicacion = Publicaciones.FirstOrDefault(p => p.Id == id);
        if (publicacion != null && !publicacion.Autores.Contains(autor))
        {
            publicacion.Autores.Add(autor);
        }
    }

    public static ObservableCollection<Publicacion> FiltrarPorTipo(TipoPublicacion tipo)
    {
        var filtradas = Publicaciones.Where(p => p.Tipo == tipo).ToList();
        return new ObservableCollection<Publicacion>(filtradas);
    }

    public static Publicacion ObtenerPorTitulo(string titulo)
    {
        return Publicaciones.FirstOrDefault(p => p.Titulo == titulo);
    }

    public static ObservableCollection<Publicacion> FiltrarPorAutor(string autor)
    {
        var filtradas = Publicaciones.Where(p => p.Autores.Contains(autor));
        return new ObservableCollection<Publicacion>(filtradas);
    }

    public static void ModificarEstado(int id, EstadoPublicacion nuevoEstado)
    {
        var publicacion = Publicaciones.FirstOrDefault(p => p.Id == id);
        if (publicacion != null)
        {
            publicacion.Estado = nuevoEstado;
        }
    }

    public static void Eliminar(string titulo)
    {
        var publicacion = ObtenerPorTitulo(titulo);
        if (publicacion != null)
        {
            Publicaciones.Remove(publicacion);
        }
    }


    public static bool Existe(int id)
    {
        return Publicaciones.Any(p => p.Id == id);
    }

    public static bool Existe(string titulo)
    {
        return Publicaciones.Any(p => p.Titulo == titulo);
    }

}