using DotNetAndElastic.Entities;
using DotNetAndElastic.ViewModel;

namespace DotNetAndElastic.Data
{
    public interface IPlayersRepository
    {
        string CreatePlayer(PlayerEntity playerEntity);

        PlayerEntity GetPlayer(int playerId);
    }
}
