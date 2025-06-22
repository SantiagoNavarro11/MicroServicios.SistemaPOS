namespace Infraestructure.SistemaPos.Datos.Mapeos
{
    using Core.SistemaPos.Entidades;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuración de mapeo de la entidad <see cref="SistemaPosTipoIdentificacion"/> 
    /// para su persistencia en la base de datos utilizando Entity Framework Core.
    /// </summary>
    public class SistemaPosTipoIdentificaionMap : IEntityTypeConfiguration<SistemaPosTipoIdentificacion>
    {
        /// <summary>
        /// Configura la entidad <see cref="SistemaPosTipoIdentificacion"/> definiendo
        /// su correspondencia con la tabla y sus restricciones en la base de datos.
        /// </summary>
        /// <param name="builder">
        /// Objeto <see cref="EntityTypeBuilder{SistemaPosTipoIdentificacion}"/> utilizado 
        /// para configurar la entidad mediante la API Fluent de EF Core.
        /// </param>
        public void Configure(EntityTypeBuilder<SistemaPosTipoIdentificacion> builder)
        {
            // Especifica el nombre de la tabla en la base de datos.
            builder.ToTable("TipoIdentificacion");

            // Define la clave pri