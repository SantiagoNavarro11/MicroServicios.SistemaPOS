namespace Infraestructure.SistemaPos.Datos.Mapeos
{
    using Core.SistemaPos.Entidades;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuración de mapeo de la entidad <see cref="SistemaPosFormasPago"/> 
    /// para su persistencia en la base de datos utilizando Entity Framework Core.
    /// </summary>
    public class SistemaPosFormasPagoMap : IEntityTypeConfiguration<SistemaPosFormasPago>
    {
        /// <summary>
        /// Configura la entidad <see cref="SistemaPosFormasPago"/> definiendo
        /// su correspondencia con la tabla y sus restricciones en la base de datos.
        /// </summary>
        /// <param name="builder">
        /// Objeto <see cref="EntityTypeBuilder{SistemaPosFormasPago}"/> utilizado 
        /// para configurar la entidad mediante la API Fluent de EF Core.
        /// </param>
        public void Configure(EntityTypeBuilder<SistemaPosFormasPago> builder)
        {
            // Especifica el nombre de la tabla en la base de datos.
            builder.ToTable("FormasPago");

            // Define la clave primaria de la tabla.
            builder.HasKey(e => e.IdFormaPago)
                .HasName("PK_FormasPago");

            // Configura la propiedad NombreMetodoPago con una longitud máxima de 40 caracteres.
            builder.Property(e => e.NombreMetodoPago)
                .HasMaxLength(40);

            // Configuración de la propiedad EstadoFormasPago (estado del cliente: activo/inactivo).
            builder.Property(e => e.EstadoMetodoPago)
                .HasMaxLength(2);

        }
    }
}
