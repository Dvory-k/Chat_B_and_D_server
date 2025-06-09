using AutoMapper;
using Core.Models;
using Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Answer, AnswerResources>().ReverseMap();
            CreateMap<AnswerDB, AnswerDBResources>().ReverseMap();
            CreateMap<Question, QuestionResources>().ReverseMap();
            CreateMap<User, UserResources>().ReverseMap();
        }
    }
}
