namespace Core.SistemaPos.EntidadesPersonalizadas
{
    /// <summary>
    /// Representa los parámetros de búsqueda utilizados para consultar 
    /// las formas de pago en el sistema POS.
    /// </summary>
    public class ParametrosSistemaPosFormasPago
    {
        /// <summary>
        /// Obtiene o establece el identificador único de la forma de pago.
        /// Este parámetro es opcional y puede utilizarse para filtrar una forma de pago específica.
        /// </summary>
        public int? IdFormaPago { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del método de pago.
        /// Este parámetro es opcional y permite realizar búsquedas basadas en el nombre de la forma de pago.
        /// </summary>
        public string? NombreMetodoPago { get; set; }

        /// <summary>
        /// Obtiene o establece el estado del metodo de pago.    
        /// Puede ser utilizado para mostrar si esta habilitado o inhabilado el metodo de pago.
        /// </summary>
        public bool? EstadoMetodoPago { get; set; }
    }
}
