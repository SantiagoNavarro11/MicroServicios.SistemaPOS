namespace Core.SistemaPos.Interface
{
    using Core.SistemaPos.Dto;
    using Core.SistemaPos.Entidades;
    using Utilitarios.Interfaces.ConfiguracionRepositorio;

    /// <summary>
    /// Define la unidad de trabajo para el acceso a datos en el sistema POS.
    /// Proporciona acceso a los repositorios CRUD de las entidades y métodos
    /// para la gestión de la conexión y persistencia en la base de datos.
    /// </summary>
    public interface IDLUnitOfWork : IDisposable
    {
        #region Instancias

        /// <summary>
        /// Repositorio CRUD para la entidad <see cref="SistemaPosFormasPago"/>.
        /// Permite realizar operaciones de consulta, inserción, actualización y eliminación
        /// sobre las formas de pago del sistema POS.
        /// </summary>
        ICrudSqlRepositorio<SistemaPosFormasPago> DLSistemaPosFormasPago { get; }

        /// <summary>
        /// Repositorio CRUD para la entidad <see cref="SistemaPosTipoIdentificacion"/>.
        /// Permite realizar operaciones de consulta, inserción, actualización y eliminación
        /// sobre los tipos de identificación del sistema POS.
        /// </summary>
        ICrudSqlRepositorio<SistemaPosTipoIdentificacion> DLSistemaPosTipoIdentificacion { get; }

        /// <summary>
        /// Repositorio CRUD para la entidad <see cref="SistemaPosCargo"/>.
        /// Permite realizar operaciones de consulta, inserción, actualización y eliminación
        /// sobre los cargos o roles del sistema POS.
        /// </summary>
        ICrudSqlRepositorio<SistemaPosCargo> DLSistemaPosCargo { get; }

        /// <summary>
        /// Repositorio CRUD para la entidad <see cref="SistemaPosCliente"/>.
        /// Permite realizar operaciones de consulta, inserción, actualización y eliminación
        /// sobre los cargos o roles del sistema POS.
        /// </summary>
        ICrudSqlRepositorio<SistemaPosCliente> DLSistemaPosCliente { get; }

        /// <summary>
        /// Repositorio CRUD para la entidad <see cref="SistemaPosUsuario"/>.
        /// Permite realizar operaciones de consulta, inserción, actualización y eliminación
        /// sobre los cargos o roles del sistema POS.
        /// </summary>
        ICrudSqlRepositorio<SistemaPosUsuario> DLSistemaPosUsuario { get; }

        #endregion

        #region Liberar Conexión

        /// <summary>
        /// Libera los recursos no administrados utilizados por la conexión de base de datos.
        /// </summary>
        void Dispose();

        /// <summary>
        /// Libera de manera asincrónica los recursos no administrados utilizados por la conexión de base de datos.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica de liberación de recursos.</returns>
        Task DisposeAsync();

        #endregion

        #region Guardar Cambios

        /// <summary>
        /// Guarda de manera sincrónica los cambios realizados en el contexto de datos
        /// y persiste las modificaciones en la base de datos.
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// Guarda de manera asincrónica los cambios realizados en el contexto de datos
        /// y persiste las modificaciones en la base de datos.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica de guardado de cambios.</returns>
        Task SaveChangesAsync();

        #endregion
    }
}
