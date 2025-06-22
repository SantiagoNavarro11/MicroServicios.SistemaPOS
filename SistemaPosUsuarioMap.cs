namespace Infraestructure.SistemaPos.Datos.Mapeos
{
    using Core.SistemaPos.Entidades;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuración de mapeo de la entidad <see cref="SistemaPosUsuario"/> 
    /// para su persistencia en la base de datos utilizando Entity Framework Core.
    /// </summary>
    public class SistemaPosUsuarioMap : IEntityTypeConfiguration<SistemaPosUsuario>
    {
        /// <summary>
        /// Configura la entidad <see cref="SistemaPosUsuario"/> definiendo
        /// su correspondencia con la tabla y sus restricciones en la base de datos.
        /// </summary>
        /// <param name="builder">
        /// Objeto <see cref="EntityTypeBuilder{SistemaPosUsuario}"/> utilizado 
        /// para configurar la entidad mediante la API Fluent de EF Core.
        /// </param>
        public void Configure(EntityTypeBuilder<SistemaPosUsuario> builder)
        {
            // Especifica el nombre de la tabla en la base de datos.
            builder.ToTable("Usuario");

            // Define la clave primaria de la tabla.
            builder.HasKey(e => e.IdUsuario)
                .HasName("PK_Usuario");

            // Configuración de la propiedad IdTipoIdentificacion (relacionada con tipo de documento).
            builder.Property(e => e.IdTipoIdentificacion)
                .HasColumnName("IdTipoIdentificacion");

            // Configuración de la propiedad IdCargo (relacionada con roles o cargos).
            builder.Property(e => e.IdCargo)
                .HasColumnName("IdCargo");

            // Configuración de la propiedad NombreUsuario (usuario de inicio de sesión).
            builder.Property(e => e.NombreUsuario)
                .HasMaxLength(100)
                .HasColumnName("NombreUsuario");

            // Configuración de la propiedad ContraseñaUsuario (clave del usuario).
            builder.Property(e => e.ContraseñaUsuario)
                .HasMaxLength(40)
                .HasColumnName("ContraseñaUsuario");

            // Configuración de la propiedad TelefonoUsuario (número de contacto).
            builder.Property(e => e.TelefonoUsuario)
                .HasMaxLength(40)
                .HasColumnName("TelefonoUsuario");

            // Configuración de la propiedad FechaNacimientoUsuario (fecha de nacimiento).
            builder.Property(e => e.FechaNacimientoUsuario)
                .HasColumnName("FechaNacimientoUsuario");

            // Configuración de la propiedad Habilitado (estado del usuario).
            builder.Property(e => e.Habilitado)
                .HasColumnName("Habilitado");

            // Configuración de la propiedad CorreoElectronico (email del usuario).
            builder.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .HasColumnName("CorreoElectronico");

            // Configuración de la propiedad NombreCompleto (nombre completo del usuario).
            builder.Property(e => e.NombreCompleto)
                .HasMaxLength(100)
                .HasColumnName("NombreCompleto");

            // Configuración de la propiedad NumeroIdentificacion (documento de identidad).
            builder.Property(e => e.NumeroIdentificacion)
                .HasMaxLength(40)
                .HasColumnName("NumeroIdentificacion");
        }
    }
}
