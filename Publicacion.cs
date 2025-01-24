using System;
using System.Collections.ObjectModel;

namespace Practica;

public enum TipoPublicacion{libro_completo,capitulo_libro,articulo_revista,congreso}
public enum EstadoPublicacion{en_revision,aceptado,rechazado}

public class Publicacion
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public ObservableCollection<string> Autores { get; set; }
    public DateTime FechaPublicacion { get; set; }
    public TipoPublicacion Tipo { get; set; }
    public EstadoPublicacion Estado { get; set; }

    public Publicacion(int id, string titulo, DateTime fechaPublicacion, TipoPublicacion tipo, EstadoPublicacion estado)
    {
        Id = id;
        Titulo = titulo;
        FechaPublicacion = fechaPublicacion;
        Tipo = tipo;
        Estado = estado;
    }

    
}
