using Application.Features.CarModels.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistance.Paging;
using Domain.Entities;

namespace Application.Features.CarModels.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Model, GetListModelListItemDto>().ForMember(destinationMember: c => c.BrandName, memberOptions: opt => opt.MapFrom(c => c.Brand.Name)).ForMember(destinationMember: c => c.FuelName, memberOptions: opt => opt.MapFrom(c => c.Fuel.Name)).ForMember(destinationMember: c => c.TransmissionName, memberOptions: opt => opt.MapFrom(c => c.Transmission.Name))
            .ReverseMap();
        CreateMap<Paginate<Model>, GetListResponse<GetListModelListItemDto>>().ReverseMap();
    }
}
