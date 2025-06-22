namespace Core.SistemaPos.Dto
{
    /// <summary>
    /// Representa los parámetros de búsqueda utilizados para consultar 
    /// los cargos en el sistema POS.
    /// </summary>
    public class ParametrosSistemaPosCliente
    {
        /// <summary>
        /// Obtiene o establece el identificador único del cliente.
        /// Este valor puede ser nulo en escenarios donde la identificación explícita no sea necesaria.
        /// </summary>
        public int? IdCliente { get; set; }

        /// <summary>
        /// Obtiene o establece el numero de identificación.
        /// Este parámetro es opcional y permite filtrar los resultados por nombre.
        /// </summary>
        public string? NumeroIdentificacion { get; set; }
        /// <summary>
        /// Obtiene o establece el telefono del cliente
        /// Este parámetro es opcional y permite filtrar los resultados por telefono.
        /// </summary>
        public string? TelefonoCliente { get; set; }
    }
}
