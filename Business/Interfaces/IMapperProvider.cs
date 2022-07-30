using AutoMapper;

namespace Business.Interfaces;

public interface IMapperProvider
{
    IMapper GetMapper();
}