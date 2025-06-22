using Utilitarios.Entidades;

namespace Core.SistemaPos.Dto
{
    /// <summary>
    /// Representa un cargo o rol en el sistema POS.
    /// Hereda de <see cref="EntidadBase"/> para incluir propiedades comunes a todas las entidades.
    /// </summary>
    public class SistemaPosCargo : EntidadBase
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
        public bool? EstadoTipoCargo { get; set; }
    }
}
