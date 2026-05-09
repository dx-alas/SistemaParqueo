using BCrypt.Net;

namespace SistemaParqueo.Desktop
{
    public class Seguridad
    {
        // Generar hash
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Verificar contraseña
        public static bool VerificarPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}