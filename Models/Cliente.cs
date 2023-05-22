using System.ComponentModel.DataAnnotations;
using Proyecto_clase;
public class Cliente{
    [Key]
    public Guid clienteId{get;set;}
    [MaxLength(100)]
    public string? nombre{get;set;}
    [MaxLength(100)]
    public string?direccion{get;set;}
    [MaxLength(15)]
    public int telefono{get;set;}
    [MaxLength(100)]
    public string? correo{get;set;}
}