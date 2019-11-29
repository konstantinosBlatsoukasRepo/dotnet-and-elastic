using AutoMapper;
using DotNetAndElastic.Entities;
using DotNetAndElastic.ViewModel;

namespace DotNetAndElastic.Profiles
{
    public class PlayerViewModelToPlayerEntity : Profile
    {
        public PlayerViewModelToPlayerEntity()
        {
            CreateMap<PlayerViewModel, PlayerEntity>();
        }
    }
}
