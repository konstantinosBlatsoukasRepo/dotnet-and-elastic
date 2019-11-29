using AutoMapper;
using DotNetAndElastic.Entities;
using DotNetAndElastic.ViewModel;

namespace DotNetAndElastic.Profiles
{
    public class PlayerEntityToPlayerViewModel : Profile
    {
        public PlayerEntityToPlayerViewModel()
        {
            CreateMap<PlayerViewModel, PlayerEntity>();
        }
    }
}
