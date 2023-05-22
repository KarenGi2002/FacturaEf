using System.ComponentModel.DataAnnotations;
using Proyecto_clase;

public class Empresa{
    [MaxLength(100)]
    public string? nombre{get;set;}
    [MaxLength(100)]
    public string? direccion{get;set;}
    public int  telefono{get;set;}
    [MaxLength(100)]
    public string? correo{get;set;}
}