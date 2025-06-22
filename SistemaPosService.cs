namespace Core.SistemaPos.Servicios
{
    using Core.SistemaPos.Dto;
    using Core.SistemaPos.Entidades;
    using Core.SistemaPos.EntidadesPersonalizadas;
    using Core.SistemaPos.Interface;
    using Core.SistemaPos.Interface.SistemaPos;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using Utilitarios;
    using Utilitarios.Extenciones;

    /// <summary>
    /// Servicio principal que implementa la interfaz <see cref="ISistemaPosService"/> 
    /// para manejar operaciones relacionadas con el sistema POS.
    /// </summary>
    public class SistemaPosService : ISistemaPosService
    {
        #region Variables

        /// <summary>
        /// Unidad de trabajo que encapsula todos los repositorios del sistema POS.
        /// </summary>
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor de la clase <see cref="SistemaPosService"/>.
        /// </summary>
        /// <param name="iDLUnitOfWork">Instancia de la unidad de trabajo para acceder a los repositorios de datos.</param>
        public SistemaPosService(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Consulta la lista de formas de pago disponibles en el sistema POS
        /// utilizando los parámetros de búsqueda especificados.
        /// </summary>
        /// <param name="parametrosBusqueda">
        /// Parámetros personalizados de búsqueda de formas de pago.
        /// </param>
        /// <returns>
        /// Una colección enumerable de objetos <see cref="SistemaPosFormasPago"/> 
        /// que cumplen con los criterios de búsqueda.
        /// </returns>
        public async Task<IEnumerable<SistemaPosFormasPago>> ConsultarFormasPago(ParametrosSistemaPosFormasPago parametrosBusqueda)
        {
            Expression<Func<SistemaPosFormasPago, bool>> filtro = parametrosBusqueda.CrearFiltro<SistemaPosFormasPago>();
            return await _iDLUnitOfWork.DLSistemaPosFormasPago.ConsultarLista(filtro);
        }

        /// <summary>
        /// Consulta la lista de tipos de identificación disponibles en el sistema POS
        /// utilizando los parámetros de búsqueda especificados.
        /// </summary>
        /// <param name="parametrosBusqueda">
        /// Parámetros personalizados de búsqueda de tipos de identificación.
        /// </param>
        /// <returns>
        /// Una colección enumerable de objetos <see cref="SistemaPosTipoIdentificacion"/> 
        /// que cumplen con los criterios de búsqueda.
        /// </returns>
        public async Task<IEnumerable<SistemaPosTipoIdentificacion>> ConsultarTipoIdentificacion(ParametrosSistemaPosTipoIdentificacion parametrosBusqueda)
        {
            Expression<Func<SistemaPosTipoIdentificacion, bool>> filtro = parametrosBusqueda.CrearFiltro<SistemaPosTipoIdentificacion>();
            return await _iDLUnitOfWork.DLSistemaPosTipoIdentificacion.ConsultarLista(filtro);
        }

        /// <summary>
        /// Consulta la lista de cargos disponibles en el sistema POS
        /// utilizando los parámetros de búsqueda especificados.
        /// </summary>
        /// <param name="parametrosBusqueda">
        /// Parámetros personalizados de búsqueda de tipos de cargos.
        /// </param>
        /// <returns>
        /// Una colección enumerable de objetos <see cref="SistemaPosCargo"/> 
        /// que cumplen con los criterios de búsqueda.
        /// </returns>
        public async Task<IEnumerable<SistemaPosCargo>> ConsultarCargo(ParametrosSistemaPosCargo parametrosBusqueda)
        {
            Expression<Func<SistemaPosCargo, bool>> filtro = parametrosBusqueda.CrearFiltro<SistemaPosCargo>();
            return await _iDLUnitOfWork.DLSistemaPosCargo.ConsultarLista(filtro);
        }

        /// <summary>
        /// Consulta la lista de clientes disponibles en el sistema POS
        /// utilizando los parámetros de búsqueda especificados.
        /// </summary>
        /// <param name="parametrosBusqueda">
        /// Parámetros personalizados de búsqueda de clientes.
        /// </param>
        /// <returns>
        /// Una colección enumerable de objetos <see cref="SistemaPosCliente"/> 
        /// que cumplen con los criterios de búsqueda.
        /// </returns>
        public async Task<IEnumerable<SistemaPosCliente>> ConsultarCliente(ParametrosSistemaPosCliente parametrosBusqueda)
        {
            Expression<Func<SistemaPosCliente, bool>> filtro = parametrosBusqueda.CrearFiltro<SistemaPosCliente>();
            return await _iDLUnitOfWork.DLSistemaPosCliente.ConsultarLista(filtro);
        }


        /// <summary>
        /// Consulta la lista de usuarios disponibles en el sistema POS
        /// utilizando los parámetros de búsqueda especificados.
        /// </summary>
        /// <param name="parametrosBusqueda">
        /// Parámetros personalizados de búsqueda de usuarios.
        /// </param>
        /// <returns>
        /// Una colección enumerable de objetos <see cref="SistemaPosUsuario"/> 
        /// que cumplen con los criterios de búsqueda.
        /// </returns>
        public async Task<IEnumerable<SistemaPosUsuario>> ConsultarUsuario(ParametrosSistemaPosUsuario parametrosBusqueda)
        {
            Expression<Func<SistemaPosUsuario, bool>> filtro = parametrosBusqueda.CrearFiltro<SistemaPosUsuario>();
            return await _iDLUnitOfWork.DLSistemaPosUsuario.ConsultarLista(filtro);
        }
        #endregion
    }
}
