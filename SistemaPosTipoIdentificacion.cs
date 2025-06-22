namespace Core.SistemaPos.Entidades
{
    using Utilitarios.Entidades;

    /// <summary>
    /// Representa un tipo de identificación dentro del sistema POS.
    /// Contiene la información necesaria para identificar un documento o entidad.
    /// </summary>
    public class SistemaPosTipoIdentificacion : EntidadBase
    {
        /// <summary>
        /// Obtiene o establece el identificador único del tipo de identificación.
        /// Este valor puede ser nulo en operaciones donde no se requiera su especificación explícita.
        /// </summary>
        public int? IdTipoIdentificacion { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre o descripción del tipo de identificación.
        /// Por ejemplo: "Cédula de Ciudadanía", "NIT", "Pasaporte", etc.
        /// Este valor es opcional en algunas operaciones.
        /// </summary>
        public string? NombreTipoIdentificacion { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre o descripción de siglas.
        /// Por ejemplo: "CC", "CE", "TI", etc.
        /// Este valor es opcional en algunas operaciones.
        /// </summary>
        public string? Siglas { get; set; }

        /// <summary>
        /// Obtiene o establece el estado del tipo de identificación. 
        /// Puede ser utilizado para mostrar si esta habilitado o inhabilado el Tipo de identificación.
        /// </summary>
        public bool? EstadoTipoIdentificacion { get; set; }
    }
}
