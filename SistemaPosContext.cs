namespace Infrastructure.SistemaPos.Datos
{
    using Core.SistemaPos.Entidades;
    using Microsoft.EntityFrameworkCore;
    using Infraestructure.SistemaPos.Datos.Mapeos;
    using Core.SistemaPos.Dto;

    /// <summary>Contexto para el manejo de peticiones de las tablas para la base de datos.</summary>
    public class SistemaPosContext : DbContext
    {
        #region Constructor

        /// <summary>Inicializa una nueva instancia de la clase Context.</summary>
        public SistemaPosContext()
        {
        }

        /// <summary>Inicializa una nueva instancia de la clase Context.</summary>
        public SistemaPosContext(DbContextOptions<SistemaPosContext> options)
            : base(options)
        {
        }


        /// <summary>Configuración del Contexto.</summary>
        /// <param name="optionsBuilder">Parámetros de configuración.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        #endregion

        #region Métodos

        /// <summary>Configura el modelo mediante el ModelBuilder.</summary>
        /// <param name="modelBuilder">Objeto ModelBuilder usado para configurar el modelo.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");
            modelBuilder.ApplyConfiguration(new SistemaPosFormasPagoMap());
            modelBuilder.ApplyConfiguration(new SistemaPosTipoIdentificaionMap());
            modelBuilder.ApplyConfiguration(new SistemaPosCargoMap());
            modelBuilder.ApplyConfiguration(new SistemaPosClienteMap());
            modelBuilder.ApplyConfiguration(new SistemaPosUsuarioMap());
        }

        #endregion

        #region Entidades
        /// <value>Declaración del DbSet SistemaPosFormasPagos.</value>
        public virtual DbSet<SistemaPosFormasPago> SistemaPosFormasPagos { get; set; }

        /// <value>Declaración del DbSet SistemaPosTipoIdentificacion.</value>
        public virtual DbSet<SistemaPosTipoIdentificacion> SistemaPosTipoIdentificacion { get; set; }

        /// <value>Declaración del DbSet SistemaPosCargo.</value>
        public virtual DbSet<SistemaPosCargo> SistemaPosCargo { get; set; }

        /// <value>Declaración del DbSet SistemaPosCliente.</value>
        public virtual DbSet<SistemaPosCliente> SistemaPosCliente { get; set; }

        /// <value>Declaración del DbSet SistemaPosUsuario.</value>
        public virtual DbSet<SistemaPosUsuario> SistemaPosUsuario { get; set; }
        #endregion

    }
}
