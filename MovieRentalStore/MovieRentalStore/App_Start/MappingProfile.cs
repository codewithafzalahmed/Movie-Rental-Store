using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MovieRentalStore.DTOs;
using MovieRentalStore.BusinessModels;
namespace MovieRentalStore.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            var config = new MapperConfiguration(cfg =>
            {
                // Domain to Dto
                cfg.CreateMap<Customer, Customer>();
                cfg.CreateMap<MembershipType, MembershipType>();
                cfg.CreateMap<Genre, Genre>();


                // Dto to Domain
                cfg.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
                cfg.CreateMap<MovieDto, Movie>().ForMember(c => c.Id, opt => opt.Ignore());

            });
            

        }
    }
}