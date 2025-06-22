namespace Core.SistemaPos.Interface
{
    using Core.SistemaPos.Interface.SistemaPos;

    /// <summary>
    /// Define la unidad de trabajo para los servicios del sistema POS.
    /// Permite acceder a las distintas instancias de los servicios disponibles.
    /// </summary>
    public interface IServiceUnitOfWork
    {
        #region Instancias

        /// <summary>
        /// Obtiene una instancia del servicio <see cref="ISistemaPosService"/>, 
        /// el cual proporciona métodos relacionados con la lógica de negocio del sistema POS.
        /// </summary>
        ISistemaPosService SistemaPosService { get; }

        #endregion
    }
}
