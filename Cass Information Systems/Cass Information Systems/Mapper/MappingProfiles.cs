using AutoMapper;
using CIS.SharedKernel.ViewModels;
using CSI.Core.Models;

namespace Cass_Information_Systems.Mapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ShipperViewModel, Shipper>().ReverseMap();
            CreateMap<CarrierViewModel, Carrier>().ReverseMap();
            CreateMap<ShipmentRateViewModel, ShipmentRate>().ReverseMap();
            CreateMap<ShipmentDetailViewModel, ShipmentDetail>().ReverseMap();
        }
    }
}
