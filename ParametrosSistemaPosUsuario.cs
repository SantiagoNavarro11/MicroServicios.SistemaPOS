namespace Core.SistemaPos.Entidades
{
    using Utilitarios.Entidades;

    /// <summary>
    /// Representa un usuario en el sistema POS.
    /// Hereda de <see cref="EntidadBase"/> para incluir propiedades comunes a todas las entidades.
    /// </summary>
    public class ParametrosSistemaPosUsuario : EntidadBase
    {
        /// <summary>
        /// Obtiene o establece el identificador único del usuario.
        /// Este valor puede ser nulo si aún no se ha asignado.
        /// </summary>
        public int? IdUsuario { get; set; }
        /// <summary>
        /// Obtiene o establece la dirección de correo electrónico del usuario.
        /// Utilizado para notificaciones, recuperación de contraseña o contacto.
        /// </summary>
        public string? CorreoElectronico { get; set; }

        /// <summary>
        /// Obtiene o establece el número de identificación oficial del usuario.
        /// Por ejemplo: cédula, NIT, pasaporte, etc.
        /// </summary>
        public string? NumeroIdentificacion { get; set; }
    }
}
