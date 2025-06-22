namespace Core.SistemaPos.Entidades
{
    using Utilitarios.Entidades;

    /// <summary>
    /// Representa un usuario en el sistema POS.
    /// Hereda de <see cref="EntidadBase"/> para incluir propiedades comunes a todas las entidades.
    /// </summary>
    public class SistemaPosUsuario : EntidadBase
    {
        /// <summary>
        /// Obtiene o establece el identificador único del usuario.
        /// Este valor puede ser nulo si aún no se ha asignado.
        /// </summary>
        public int? IdUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador del tipo de identificación utilizado por el usuario.
        /// Relacionado con la entidad <c>SistemaPosTipoIdentificacion</c>.
        /// </summary>
        public int? IdTipoIdentificacion { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador del cargo o rol que tiene asignado el usuario dentro del sistema.
        /// Relacionado con la entidad de cargos o roles.
        /// </summary>
        public int? IdCargo { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre de usuario utilizado para el inicio de sesión en el sistema.
        /// </summary>
        public string? NombreUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece la contraseña del usuario para autenticación en el sistema.
        /// Es recomendable que este valor se almacene de forma segura (por ejemplo, hasheada).
        /// </summary>
        public string? ContraseñaUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece el número telefónico de contacto del usuario.
        /// Este campo puede ser usado para notificaciones o recuperación de cuenta.
        /// </summary>
        public string? TelefonoUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de nacimiento del usuario.
        /// Utiliza el tipo <see cref="DateOnly"/> para representar únicamente la fecha sin hora.
        /// </summary>
        public DateOnly? FechaNacimientoUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica si el usuario se encuentra habilitado para acceder al sistema.
        /// </summary>
        public bool? Habilitado { get; set; }

        /// <summary>
        /// Obtiene o establece la dirección de correo electrónico del usuario.
        /// Utilizado para notificaciones, recuperación de contraseña o contacto.
        /// </summary>
        public string? CorreoElectronico { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre completo del usuario.
        /// Incluye nombre(s) y apellido(s) según la convención local.
        /// </summary>
        public string? NombreCompleto { get; set; }

        /// <summary>
        /// Obtiene o establece el número de identificación oficial del usuario.
        /// Por ejemplo: cédula, NIT, pasaporte, etc.
        /// </summary>
        public string? NumeroIdentificacion { get; set; }
    }
}
