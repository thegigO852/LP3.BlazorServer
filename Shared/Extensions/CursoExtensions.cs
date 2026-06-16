using LP3.BlazorServer.Domain.Entities;
using LP3.Shared.DTOs;

namespace LP3.Shared.Extensions;

public static class CursoExtensions
{
    public static CursoDto ToDto(this Curso c)
        => new()
        {
            Id       = c.Id,
            Nombre   = c.Nombre,
            Codigo   = c.Codigo,
            Creditos = c.Creditos,
            Activo   = c.Activo
        };

    public static Curso ToEntity(this CursoFormDto dto)
        => new()
        {
            Id       = dto.Id ?? 0,
            Nombre   = dto.Nombre,
            Codigo   = dto.Codigo,
            Creditos = dto.Creditos,
            Activo   = dto.Activo
        };
}
