namespace LP3.Shared.Extensions;
<<<<<<< HEAD
using LP3.Domain.Entities;
using LP3.Shared.DTOs;
=======
using LP3.BlazorServer.Domain.Entities;
using LP3.BlazorServer.Shared.DTOs;
>>>>>>> 5588efae4a35a42fc15e9c6146a8cf14d7d3eeeb

/// <summary>
/// Métodos de conversión entre Entidad y DTO.
/// </summary>
public static class EstudianteExtensions
{
    public static EstudianteDto ToDto(this Estudiante e)
        => new()
        {
            Id        = e.Id,
            Nombre    = e.Nombre,
            Apellido  = e.Apellido,
            Matricula = e.Matricula,
            Estado    = e.Estado.ToString()
        };

    public static Estudiante ToEntity(this EstudianteFormDto dto)
        => new()
        {
            Nombre    = dto.Nombre,
            Apellido  = dto.Apellido,
            Matricula = dto.Matricula,
            Email     = dto.Email,
            Estado    = dto.Estado
        };
}