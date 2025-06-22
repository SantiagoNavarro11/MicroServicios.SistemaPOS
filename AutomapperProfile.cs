namespace Infrastructure.PaginaWeb.Mapeos
{
    using AutoMapper;
    using Core.SistemaPos.Dto;
    using Core.SistemaPos.Entidades;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    /// <summary>
    /// Perfil de AutoMapper que define las conversiones (mapeos) entre entidades de base de datos
    /// y objetos Data Transfer Object (DTO) para el sistema POS.
    /// </summary>
    public class AutomapperProfile : Profile
    {
        #region Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="AutomapperProfile"/>.
        /// Configura los mapeos bidireccionales entre entidades y DTOs
        /// mediante la funcionalidad <c>ReverseMap()</c> de AutoMapper.
        /// </summary>
        public AutomapperProfile()
        {
            // Mapeo entre SistemaPosFormasPagoDto y SistemaPosFormasPago (bidireccional)
            CreateMap<SistemaPosFormasPagoDto, SistemaPosFormasPago>()
                .ReverseMap();

            // Mapeo entre SistemaPosTipoIdentificacionDto y SistemaPosTipoIdentificacion (bidireccional)
            CreateMap<SistemaPosTipoIdentificacionDto, SistemaPosTipoIdentificacion>()
                .ReverseMap();

            // Mapeo entre SistemaPosCargoDto y SistemaPosCargo (bidireccional)
            CreateMap<SistemaPosCargo, SistemaPosCargoDto>()
                .ReverseMap();

            // Mapeo entre SistemaPosClienteDto y SistemaPosCliente (bidireccional)
            CreateMap<SistemaPosCliente, SistemaPosClienteDto>()
                .ReverseMap();

            // Mapeo entre SistemaPosUsuarioDto y SistemaPosUsuario (bidireccional)
            CreateMap<SistemaPosUsuario, SistemaPosUsuarioDto>()
                .ReverseMap();
        }

        #endregion
    }
}
