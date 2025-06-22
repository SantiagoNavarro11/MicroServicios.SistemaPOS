namespace Core.SistemaPos.Dto
{
    /// <summary>
    /// Data Transfer Object (DTO) que representa un tipo de identificación
    /// en el sistema POS. Utilizado para transportar datos entre capas
    /// sin exponer directamente la entidad de base de datos.
    /// </summary>
    public class SistemaPosTipoIdentificacionDto
    {
        /// <summary>
        /// Obtiene o establece el identificador único del tipo de identificación.
        /// Este valor puede ser nulo cuando no es necesario especificarlo explícitamente.
        /// </summary>
        public int? IdTipoIdentificacion { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre o descripción del tipo de identificación.
        /// Por ejemplo: "Cédula", "NIT", "Pasaporte", etc.
        /// Este valor es opcional dependiendo de la operación que se realice.
        /// </summary>
        public string? NombreTipoIdentificacion { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre o descripción de siglas.
        /// Por ejemplo: "CC", "CE", "TI", etc.        
        /// Este valor es opcional dependiendo de la operación que se realice.
        /// </summary>
        public string? Siglas { get; set; }

        /// <summary>
        /// Obtiene o establece el estado del tipo de identificacion   
        /// Puede ser utilizado para mostrar si esta habilitado o inhabilado el cliente.
        /// </summary>
        public bool? EstadoTipoIdentifiacion { get; set; }
    }
}
