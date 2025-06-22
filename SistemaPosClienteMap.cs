namespace Infraestructure.SistemaPos.Datos.Mapeos
{
    using Core.SistemaPos.Entidades;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuración de mapeo de la entidad <see cref="SistemaPosCliente"/> 
    /// para su persistencia en la base de datos utilizando Entity Framework Core.
    /// </summary>
    public class SistemaPosClienteMap : IEntityTypeConfiguration<SistemaPosCliente>
    {
        /// <summary>
        /// Configura la entidad <see cref="SistemaPosCliente"/> definiendo
        /// su correspondencia con la tabla y sus restricciones en la base de datos.
        /// </summary>
        /// <param name="builder">
        /// Objeto <see cref="EntityTypeBuilder{SistemaPosCliente}"/> utilizado 
        /// para configurar la entidad mediante la API Fluent de EF Core.
        /// </param>
        public void Configure(EntityTypeBuilder<SistemaPosCliente> builder)
        {
            // Especifica el nombre de la tabla en la base de datos.
            builder.ToTable("Cliente");

            // Define la clave primaria de la tabla.
            builder.HasKey(e => e.IdCliente)
                .HasName("PK_Cliente");

            // Configuración de la propiedad NombreCliente (nombre completo del cliente).
            builder.Property(e => e.NombreCliente)
                .HasMaxLength(100)
                .HasColumnName("NombreCliente");

            // Configuración de la propiedad NumeroIdentificacion (documento del cliente).
            builder.Property(e => e.NumeroIdentificacion)
                .HasMaxLength(40)
                .HasColumnName("NumeroIdentificacion");

            // Configuración de la propiedad CorreoElectronico (email del cliente).
            builder.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .HasColumnName("CorreoElectronico");

            // Configuración de la propiedad TelefonoCliente (número telefónico del cliente).
            builder.Property(e => e.TelefonoCliente)
                .HasMaxLength(40)
                .HasColumnName("TelefonoCliente");

            // Configuración de la propiedad IdTipoIdentificacion (clave foránea hacia TipoIdentificacion).
            builder.Property(e => e.IdTipoIdentificacion)
                .HasColumnName("IdTipoIdentificacion");

            // Configuración de la propiedad IdUsuario (clave foránea hacia Usuario que creó o gestiona este cliente).
            builder.Property(e => e.IdUsuario)
                .HasColumnName("IdUsuario");

            // Configuración de la propiedad EstadoCliente (estado del cliente: activo/inactivo).
            builder.Property(e => e.EstadoCliente)
                .HasColumnName("EstadoCliente");
        }
    }
}
