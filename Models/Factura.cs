
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto_clase;

public class Factura{
[Key]
 public Guid facturaId{get;set;}
 [MaxLength(100)]
public string? producto{get;set;}

[NotMapped]
[ForeignKey("nombre")]
public virtual ICollection <Cliente>? Cliente{get;set;}
}