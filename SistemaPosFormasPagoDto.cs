namespace Core.SistemaPos.Dto
{
    /// <summary>
    /// Data Transfer Object (DTO) que representa una forma o método de pago.
    /// en el sistema POS. Utilizado para transferir datos entre capas.
    /// sin exponer directamente la entidad de base de datos.
    /// </summary>
    public class SistemaPosFormasPagoDto
    {
        /// <summary>
        /// Obtiene o establece el identificador único de la forma de pago.
        /// Este valor puede ser nulo en escenarios donde no se requiera especificación explícita.
        /// </summary>
        public int? IdFormaPago { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre o descripción del método de pago.
        /// Por ejemplo: "Efectivo", "Tarjeta Débito", "Transferencia Electrónica", etc.
        /// Este valor es opcional dependiendo de la operación realizada.
        /// </summary>
        public string? NombreMetodoPago { get; set; }

        /// <summary>
        /// Obtiene o establece el estado del metodo de pago.    
        /// Puede ser utilizado para mostrar si esta habilitado o inhabilado el metodo de pago.
        /// </summary>
        public bool? EstadoMetodoPago { get; set; }
    }
}
