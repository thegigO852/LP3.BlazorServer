using System.ComponentModel.DataAnnotations;

namespace LP3.Shared.DTOs;

/// <summary>DTO para mostrar cursos en listados.</summary>
public class CursoDto
{
    public int    Id       { get; set; }
    public string Nombre   { get; set; } = string.Empty;
    public string Codigo   { get; set; } = string.Empty;
    public int    Creditos { get; set; }
    public bool   Activo   { get; set; }
}

/// <summary>DTO para crear o editar un curso.</summary>
public class CursoFormDto
{
    public int?   Id       { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre   { get; set; } = string.Empty;

    [Required(ErrorMessage = "El código es obligatorio.")]
    public string Codigo   { get; set; } = string.Empty;

    [Range(1, 30, ErrorMessage = "Los créditos deben ser un valor entre 1 y 30.")]
    public int    Creditos { get; set; }

    public bool   Activo   { get; set; } = true;
}
