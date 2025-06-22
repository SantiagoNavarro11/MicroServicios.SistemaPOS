namespace Core.SistemaPos.Interface.SistemaPos
{
    using Core.SistemaPos.Dto;
    using Core.SistemaPos.Entidades;
    using Core.SistemaPos.EntidadesPersonalizadas;

    /// <summary>
    /// Define la interfaz para los servicios relacionados con el sistema POS.
    /// Contiene las operaciones disponibles para consultar formas de pago 
    /// y tipos de identificación dentro del sistema.
    /// </summary>
    public interface ISistemaPosService
    {
        /// <summary>
        /// Consulta la lista de formas de pago disponibles en el sistema POS,
        /// utilizando los parámetros de búsqueda especificados.
        /// </summary>
        /// <param name="parametrosBusqueda">
        /// Parámetros personalizados que definen los criterios de búsqueda 
        /// para las formas de pago.
        /// </param>
        /// <returns>
        /// Una colección enumerable de objetos <see cref="SistemaPosFormasPago"/> 
        /// que cumplen con los criterios de búsqueda especificados.
        /// </returns>
        Task<IEnumerable<SistemaPosFormasPago>> ConsultarFormasPago(ParametrosSistemaPosFormasPago parametrosBusqueda);

        /// <summary>
        /// Consulta la lista de tipos de identificación disponibles en el sistema POS,
        /// utilizando los parámetros de búsqueda especificados.
        /// </summary>
        /// <param name="parametrosBusqueda">
        /// Parámetros personalizados que definen los criterios de búsqueda 
        /// para los tipos de identificación.
        /// </param>
        /// <returns>
        /// Una colección enumerable de objetos <see cref="SistemaPosTipoIdentificacion"/> 
        /// que cumplen con los criterios de búsqueda especificados.
        /// </returns>
        Task<IEnumerable<SistemaPosTipoIdentificacion>> ConsultarTipoIdentificacion(ParametrosSistemaPosTipoIdentificacion parametrosBusqueda);

        /// <summary>
        /// Consulta la lista de cargos disponibles en el sistema POS,
        /// utilizando los parámetros de búsqueda especificados.
        /// </summary>
        /// <param name="parametrosBusqueda">
        /// Parámetros personalizados que definen los criterios de búsqueda 
        /// para los tipos de identificación.
        /// </param>
        /// <returns>
        /// Una colección enumerable de objetos <see cref="SistemaPosCargo"/> 
        /// que cumplen con los criterios de búsqueda especificados.
        /// </returns>
        Task<IEnumerable<SistemaPosCargo>> ConsultarCargo(ParametrosSistemaPosCargo parametrosBusqueda);

        /// <summary>
        /// Consulta la lista de clientes disponibles en el sistema POS,
        /// utilizando los parámetros de búsqueda especificados.
        /// </summary>
        /// <param name="parametrosBusqueda">
        /// Parámetros personalizados que definen los criterios de búsqueda 
        /// para los clientes
        /// </param>
        /// <returns>
        /// Una colección enumerable de objetos <see cref="ParametrosSistemaPosCliente"/> 
        /// que cumplen con los criterios de búsqueda especificados.
        /// </returns>
        Task<IEnumerable<SistemaPosCliente>> ConsultarCliente(ParametrosSistemaPosCliente parametrosBusqueda);

        /// <summary>
        /// Consulta la lista de usuarios disponibles en el sistema POS,
        /// utilizando los parámetros de búsqueda especificados.
        /// </summary>
        /// <param name="parametrosBusqueda">
        /// Parámetros personalizados que definen los criterios de búsqueda 
        /// para los usuarios.
        /// </param>
        /// <returns>
        /// Una colección enumerable de objetos <see cref="SistemaPosUsuario"/> 
        /// que cumplen con los criterios de búsqueda especificados.
        /// </returns>
        Task<IEnumerable<SistemaPosUsuario>> ConsultarUsuario(ParametrosSistemaPosUsuario parametrosBusqueda);
    }
}
