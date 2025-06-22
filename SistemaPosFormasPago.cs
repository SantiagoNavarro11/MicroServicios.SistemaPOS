namespace Core.SistemaPos.Entidades
{
    using Utilitarios.Entidades;

    /// <summary>
    /// Representa una forma o método de pago en el sistema POS.
    /// Hereda de <see cref="EntidadBase"/> para incluir propiedades comunes a todas las entidades.
    /// </summary>
    public class SistemaPosFormasPago : EntidadBase
    {
        /// <summary>
        /// Obtiene o establece el identificador único de la forma de pago.
        /// Este valor puede ser nulo en escenarios donde la identificación explícita no sea necesaria.
        /// </summary>
        public int? IdFormaPago { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre o descripción del método de pago.
        /// Por ejemplo: "Efectivo", "Tarjeta de Crédito", "Transferencia Bancaria", etc.
        /// Este valor es opcional en ciertas operaciones.
        /// </summary>
        public string? NombreMetodoPago { get; set; }

        /// <summary>
        /// Obtiene o establece el estado del tipo de identificacion   
        /// Puede ser utilizado para mostrar si esta habilitado o inhabilado el cliente.
        /// </summary>
        public bool? EstadoMetodoPago { get; set; }

    }
}
