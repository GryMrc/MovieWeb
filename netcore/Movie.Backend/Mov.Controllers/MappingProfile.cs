using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mov.Controllers
{
    public class MappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "MappingProfile";
            }
        }

        public MappingProfile()
        {
            ConfigureMappings();
        }


        /// <summary>
        /// Creates a mapping between source (Domain) and destination (ViewModel)
        /// </summary>
        private void ConfigureMappings()
        {
            CreateMap<DataModels.User.User, ViewModels.User.User>().ReverseMap();
        }
    }
}
