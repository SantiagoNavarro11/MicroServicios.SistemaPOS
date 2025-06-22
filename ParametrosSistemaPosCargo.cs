namespace Core.SistemaPos.Dto
{
    /// <summary>
    /// Representa los parámetros de búsqueda utilizados para consultar 
    /// los cargos en el sistema POS.
    /// </summary>
    public class ParametrosSistemaPosCargo
    {
        /// <summary>
        /// Obtiene o establece el Id del cargo
        /// Este parámetro es opcional y permite filtrar los resultados por Id.
        /// </summary>
        public int? IdCargo { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del cargo.
        /// Este parámetro es opcional y permite filtrar los resultados por nombre del cargo.
        /// </summary>
        public string? NombreTipoCargo { get; set; }

        /// <summary>
        /// Obtiene o establece el estado del tipo cargo.
        /// Puede ser utilizado para mostrar si esta habilitado o inhabilado el metodo de pago.
        /// </summary>
        public bool? EstadoTipoPago { get; set; }
    }
}
