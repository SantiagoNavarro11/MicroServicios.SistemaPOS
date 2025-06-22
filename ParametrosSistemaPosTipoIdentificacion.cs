namespace Core.SistemaPos.EntidadesPersonalizadas
{
    /// <summary>
    /// Representa los parámetros de búsqueda utilizados para consultar 
    /// los tipos de identificación en el sistema POS.
    /// </summary>
    public class ParametrosSistemaPosTipoIdentificacion
    {
        /// <summary>
        /// Obtiene o establece el identificador único del tipo de identificación.
        /// Este parámetro es opcional y puede ser nulo para consultas más amplias.
        /// </summary>
        public int? IdTipoIdentificacion { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del tipo de identificación.
        /// Este parámetro es opcional y permite filtrar los resultados por nombre.
        /// </summary>
        public string? NombreTipoIdentificacion { get; set; }

        /// <summary>
        /// Obtiene o establece el estado del tipo de identificación. 
        /// Puede ser utilizado para mostrar si esta habilitado o inhabilado el Tipo de identificación.
        /// </summary>
        public bool? EstadoTipoIdentificacion { get; set; }
    }
}
