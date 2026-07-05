using AutoMapper;
using Domain.Models;
using Infrastructure.Dto;

namespace Infrastructure.AutoMapper;

public class CandidateProfile : Profile
{
    public CandidateProfile()
    {
        CreateMap<CandidateCreate, Candidate>();
    }
}
