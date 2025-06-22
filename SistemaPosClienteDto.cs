namespace Core.SistemaPos.Entidades
{
    using Utilitarios.Entidades;

    /// <summary>
    /// Data Transfer Object (DTO) que representa un cliente
    /// en el sistema POS. Utilizado para transferir datos entre capas
    /// sin exponer directamente la entidad de base de datos.
    /// </summary>
    public class SistemaPosClienteDto : EntidadBase
    {
        /// <summary>
        /// Obtiene o establece el identificador único del cliente.
        /// Este valor puede ser nulo en escenarios donde la identificación explícita no sea necesaria.
        /// </summary>
        public int? IdCliente { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre completo del cliente.
        /// Este valor puede ser nulo si no se proporciona información personal.
        /// </summary>
        public string? NombreCliente { get; set; }

        /// <summary>
        /// Obtiene o establece el número de identificación del cliente.
        /// Por ejemplo: cédula, NIT, pasaporte, etc.
        /// Este valor es opcional dependiendo del tipo de operación realizada.
        /// </summary>
        public string? NumeroIdentificacion { get; set; }

        /// <summary>
        /// Obtiene o establece la dirección de correo electrónico del cliente.
        /// Este dato puede ser útil para notificaciones o facturación electrónica.
        /// </summary>
        public string? CorreoElectronico { get; set; }

        /// <summary>
        /// Obtiene o establece el número telefónico de contacto del cliente.
        /// Puede ser utilizado para notificaciones, contacto o asistencia técnica.
        /// </summary>
        public string? TelefonoCliente { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador del tipo de identificación utilizado por el cliente.
        /// Corresponde a la clave foránea de la entidad <c>SistemaPosTipoIdentificacion</c>.
        /// </summary>
        public int? IdTipoIdentificacion { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador del usuario asociado a este cliente en el sistema.
        /// Corresponde a la clave foránea de la entidad <c>SistemaPosUsuario</c>.
        /// </summary>
        public int? IdUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece el estado del cliente.      
        /// Puede ser utilizado para mostrar si esta habilitado o inhabilado el cliente.
        /// </summary>
        public bool? EstadoCliente { get; set; }
    }
}
