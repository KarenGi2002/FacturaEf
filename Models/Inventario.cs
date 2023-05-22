using System.ComponentModel.DataAnnotations;
using Proyecto_clase;

public class Inventario{
[Key]
    public Guid productoId{get;set;}
    
    public int cantidad{get;set;}
}