namespace Utilitarios.Interfaces.ConfiguracionRepositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;
    using Utilitarios.Entidades;

    public interface ICrudSqlRepositorio<T> where T : EntidadBase
    {
        #region Consulta

        /// <summary>Método para consultar un registro de la entidad requerida</summary>
        /// <returns>Registro de la entidad encontrada</returns>
        Task<T> ConsultarPorId(byte id);

        /// <summary>Método para consultar un registro de la entidad requerida</summary>
        /// <returns>Registro de la entidad encontrada</returns>
        Task<T> ConsultarPorId(short id);

        /// <summary>Método para consultar un registro de la entidad requerida</summary>
        /// <returns>Registro de la entidad encontrada</returns>
        Task<T> ConsultarPorId(int id);

        /// <summary>Método para consultar un registro de la entidad requerida</summary>
        /// <returns>Registro de la entidad encontrada</returns>
        Task<T> ConsultarPorId(long id);

        /// <summary>Método para consultar un registro de Fosyga según los parametros recibidos en objBusqueda.</summary>
        /// <param name="objBusqueda">Contiene los filtros de busqueda para retornar el registro encontrado.</param>
        /// <returns>Objeto Fosyga encontrado.</returns>
        Task<T> ConsultarObjeto(Expression<Func<T, bool>> objBusqueda);

        /// <summary>Método para consultar todos los registros de la entidad requerida</summary>
        /// <returns>Lista de registros de la entidad encontradas</returns>
        IEnumerable<T> ConsultarTodos();

        /// <summary>Método para consultar todos los registros de la entidad requerida.</summary>
        /// <returns>Lista de registros de la entidad encontradas.</returns>
        IEnumerable<T> ConsultarTodosFiltroQuery(Expression<Func<T, bool>> objBusqueda);

        /// <summary>Método para consultar una lista según los parametros recibidos en objBusqueda.</summary>
        /// <param name="objBusqueda">Contiene los filtros de busqueda para retornar la lista de registros encontrados.</param>
        /// <returns>Lista de todos los registros encontrados.</returns>
        Task<IEnumerable<T>> ConsultarLista(Expression<Func<T, bool>> objBusqueda);

        #endregion

        #region Adicionar

        /// <summary>Método para adicionar un registro de la entidad requerida</summary>
        /// <param name="objAdicionar">Entidad que será adicionada</param>
        /// <returns>Entidad con el identifador del registro adicionado.</returns>
        Task Adicionar(T objAdicionar);

        /// <summary>Método para adicionar registros de la entidad de manera masiva</summary>
        /// <param name="lstAdicionar">Lista de entidad que será adicionado</param>
        /// <returns>true/false si fueron adicionados.</returns>
        Task AdicionarMasivo(List<T> lstAdicionar);

        #endregion

        #region Actualizar

        /// <summary>Método para actualizar un registro en la entidad</summary>
        /// <param name="objActualizar">Entidad que será actualizada</param>
        /// <returns>Verdadero en caso que la entidad se actualice correctamente o falso en caso contrario.</returns>
        void Actualizar(T objActualizar);

        /// <summary>Método para actualizar un registro en la entidad.</summary>
        /// <param name="objActualizar">Entidad que será actualizada.</param>
        /// <returns>Verdadero en caso que la entidad se actualice correctamente o falso en caso contrario.</returns>
        Task ActualizarAsync(T objActualizar);

        #endregion

        #region Eliminar

        /// <summary>Método para eliminar un registro en la entidad</summary>
        /// <param name="id">Identificador de la entidad a eliminar</param>
        /// <returns>Verdadero en caso que la entidad se elimine correctamente o falso en caso contrario.</returns>
        Task Eliminar(int id);

        /// <summary>Método para eliminar un registro en la entidad</summary>
        /// <param name="id">Identificador de la entidad a eliminar</param>
        /// <returns>Verdadero en caso que la entidad se elimine correctamente o falso en caso contrario.</returns>
        Task Eliminar(long id);

        /// <summary>Método para eliminar un registro en la entidad</summary>
        /// <param name="objEliminar">Información de la entidad a eliminar</param>
        /// <returns>Verdadero en caso que la entidad se elimine correctamente o falso en caso contrario.</returns>
        void Eliminar(T objEliminar);

        /// <summary>Método para eliminar un registro en la entidad</summary>
        /// <param name="objEliminar">Información de la entidad a eliminar</param>
        /// <returns>Verdadero en caso que la entidad se elimine correctamente o falso en caso contrario.</returns>
        Task EliminarAsync(T objEliminar);

        /// <summary>Método para eliminar un grupo de registros</summary>
        /// <param name="objEliminar">Información de la entidad a eliminar</param>
        /// <returns>Verdadero en caso que la entidad se elimine correctamente o falso en caso contrario.</returns>
        Task EliminarMasivoAsync(List<T> objEliminar);

        #endregion

    }
}
