namespace Core.SistemaPos.Dto
{
    /// <summary>
    /// Data Transfer Object (DTO) que representa una forma o método de pago
    /// en el sistema POS. Utilizado para transferir datos entre capas
    /// sin exponer directamente la entidad de base de datos.
    /// </summary>
    public class SistemaPosCargoDto
    {
        /// <summary>
        /// Obtiene o establece el identificador único del cargo.
        /// Este valor puede ser nulo en escenarios donde no se requiera especificación explícita.
        /// </summary>
        public int? IdCargo { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre o descripción del cargo.
        /// Por ejemplo: "Dueno", "Empleado", "Contador", etc.
        /// Este valor es opcional dependiendo de la operación realizada.
        /// </summary>
        public string? NombreTipoCargo { get; set; }

        /// <summary>
        /// Obtiene o establece el estado del cargo.     
        /// Puede ser utilizado para mostrar si esta habilitado o inhabilado el cargo.
        /// </summary>
        public bool? EstadoCargo { get; set; }
    }