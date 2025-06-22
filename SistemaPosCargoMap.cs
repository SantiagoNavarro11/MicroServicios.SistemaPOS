namespace Infraestructure.SistemaPos.Datos.Mapeos
{
    using Core.SistemaPos.Dto;
    using Core.SistemaPos.Entidades;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;


    /// <summary>
    /// Configuración de mapeo de la entidad <see cref="SistemaPosCargo"/> 
    /// para su persistencia en la base de datos utilizando Entity Framework Core.
    /// </summary>
    public class SistemaPosCargoMap : IEntityTypeConfiguration<SistemaPosCargo>
    {
        /// <summary>
        /// Configura la entidad <see cref="SistemaPosCargo"/> definiendo
        /// su correspondencia con la tabla y sus restricciones en la base de datos.
        /// </summary>
        /// <param name="builder">
        /// Objeto <see cref="EntityTypeBuilder{SistemaPosCargo}"/> utilizado 
        /// para configurar la entidad mediante la API Fluent de EF Core.
        /// </param>
        public void Configure(EntityTypeBuilder<SistemaPosCargo> builder)
        {
            // Especifica el nombre de la tabla en la base de datos.
            builder.ToTable("Cargo");

            // Define la clave primaria de la tabla.
            builder.HasKey(e => e.IdCargo)
                .HasName("PK_FormasPago");

            // Configura la propiedad NombreTipoCargo con una longitud máxima de 60 caracteres.
            builder.Property(e => e.NombreTipoCargo)
                .HasMaxLength(60);

            // Configuración de la propiedad EstadoTipoCargo (estado del cliente: activo/inactivo).
            builder.Property(e => e.EstadoTipoCargo)
                .HasColumnName("EstadoTipoCargo");

        }
    }
}
