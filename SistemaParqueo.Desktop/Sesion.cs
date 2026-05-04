using SistemaParqueo.Entities;

public static class Sesion
{
    public static Usuario UsuarioActual { get; set; } // Usuario que inició sesión

    public static CorteCaja CorteActivo { get; set; } // Corte activo en el sistema
}