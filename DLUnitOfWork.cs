namespace Infrastructure.PaginaWeb.Repositorio
{
    using Core.SistemaPos.Dto;
    using Core.SistemaPos.Entidades;
    using Core.SistemaPos.Interface;
    using Infrastructure.SistemaPos.Datos;
    using Utilitarios.ConfiguracionRepositorio;
    using Utilitarios.Interfaces.ConfiguracionRepositorio;

    /// <summary>
    /// Implementación de la unidad de trabajo (Unit of Work) para el acceso a datos
    /// en el sistema POS. Gestiona la instanciación y acceso a los repositorios de entidades,
    /// así como la persistencia y liberación de recursos de la base de datos.
    /// </summary>
    public class DLUnitOfWork : IDLUnitOfWork
    {
        #region Variables

        /// <summary>
        /// Contexto de base de datos del sistema POS utilizado para acceder a las entidades.
        /// </summary>
        private readonly SistemaPosContext _conexionBD;

        /// <summary>
        /// Instancia del repositorio para la entidad <see cref="SistemaPosFormasPago"/>.
        /// </summary>
        private readonly ICrudSqlRepositorio<SistemaPosFormasPago> _iDLSistemaPosFormasPago;

        /// <summary>
        /// Instancia del repositorio para la entidad <see cref="SistemaPosTipoIdentificacion"/>.
        /// </summary>
        private readonly ICrudSqlRepositorio<SistemaPosTipoIdentificacion> _iDLSistemaPosTipoIdentificacion;

        /// <summary>
        /// Instancia del repositorio para la entidad <see cref="SistemaPosCargo"/>.
        /// </summary>
        private readonly ICrudSqlRepositorio<SistemaPosCargo> _iDLSistemaPosCargo;

        /// <summary>
        /// Instancia del repositorio para la entidad <see cref="SistemaPosCliente"/>.
        /// </summary>
        private readonly ICrudSqlRepositorio<SistemaPosCliente> _iDLSistemaPosCliente;

        /// <summary>
        /// Instancia del repositorio para la entidad <see cref="SistemaPosUsuario"/>.
        /// </summary>
        private readonly ICrudSqlRepositorio<SistemaPosUsuario> _iDLSistemaPosUsuario;

        #endregion

        #region Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DLUnitOfWork"/>.
        /// </summary>
        /// <param name="conexionSqlBD">
        /// Instancia del contexto de base de datos <see cref="SistemaPosContext"/> que será utilizado por los repositorios.
        /// </param>
        public DLUnitOfWork(SistemaPosContext conexionSqlBD)
        {
            _conexionBD = conexionSqlBD;
        }

        #endregion

        #region Instancias

        /// <summary>
        /// Obtiene una instancia del repositorio para la entidad <see cref="SistemaPosFormasPago"/>.
        /// Si la instancia no existe, se crea una nueva utilizando la conexión actual.
        /// </summary>
        public ICrudSqlRepositorio<SistemaPosFormasPago> DLSistemaPosFormasPago =>
            _iDLSistemaPosFormasPago ?? new CrudSqlRepositorio<SistemaPosFormasPago>(_conexionBD);

        /// <summary>
        /// Obtiene una instancia del repositorio para la entidad <see cref="SistemaPosTipoIdentificacion"/>.
        /// Si la instancia no existe, se crea una nueva utilizando la conexión actual.
        /// </summary>
        public ICrudSqlRepositorio<SistemaPosTipoIdentificacion> DLSistemaPosTipoIdentificacion =>
            _iDLSistemaPosTipoIdentificacion ?? new CrudSqlRepositorio<SistemaPosTipoIdentificacion>(_conexionBD);

        /// <summary>
        /// Obtiene una instancia del repositorio para la entidad <see cref="SistemaPosCargo"/>.
        /// Si la instancia no existe, se crea una nueva utilizando la conexión actual.
        /// </summary>
        public ICrudSqlRepositorio<SistemaPosCargo> DLSistemaPosCargo =>
            _iDLSistemaPosCargo ?? new CrudSqlRepositorio<SistemaPosCargo>(_conexionBD);

        /// <summary>
        /// Obtiene una instancia del repositorio para la entidad <see cref="SistemaPosUsuario"/>.
        /// Si la instancia no existe, se crea una nueva utilizando la conexión actual.
        /// </summary>
        public ICrudSqlRepositorio<SistemaPosUsuario> DLSistemaPosUsuario =>
            _iDLSistemaPosUsuario ?? new CrudSqlRepositorio<SistemaPosUsuario>(_conexionBD);
        /// <summary>
        /// Obtiene una instancia del repositorio para la entidad <see cref="SistemaPosCliente"/>.
        /// Si la instancia no existe, se crea una nueva utilizando la conexión actual.
        /// </summary>
        public ICrudSqlRepositorio<SistemaPosCliente> DLSistemaPosCliente =>
            _iDLSistemaPosCliente ?? new CrudSqlRepositorio<SistemaPosCliente>(_conexionBD);

        #endregion

        #region Liberar Conexión

        /// <summary>
        /// Libera los recursos no administrados utilizados por el contexto de base de datos de manera sincrónica.
        /// </summary>
        public void Dispose()
        {
            if (_conexionBD != null)
                _conexionBD.Dispose();
        }

        /// <summary>
        /// Libera los recursos no administrados utilizados por el contexto de base de datos de manera asincrónica.
        /// </summary>
        public async Task DisposeAsync()
        {
            if (_conexionBD != null)
                await _conexionBD.DisposeAsync();
        }

        #endregion

        #region Guardar Cambios

        /// <summary>
        /// Guarda de manera sincrónica todos los cambios realizados en el contexto de datos 
        /// y los persiste en la base de datos.
        /// </summary>
        public void SaveChanges() => _conexionBD.SaveChanges();

        /// <summary>
        /// Guarda de manera asincrónica todos los cambios realizados en el contexto de datos 
        /// y los persiste en la base de datos.
        /// </summary>
        public async Task SaveChangesAsync() => await _conexionBD.SaveChangesAsync();

        #endregion
    }
}
