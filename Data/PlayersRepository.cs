using DotNetAndElastic.Entities;
using DotNetAndElastic.Services;
using System;

namespace DotNetAndElastic.Data
{
    public class PlayersRepository : IPlayersRepository
    {
        private readonly IElasticClient _elasticClient;


        public PlayersRepository(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public PlayerEntity GetPlayer(int playerId)
        {
            var playerEntity = new PlayerEntity();
            playerEntity.CurrentTeam = "Barcelona";
            playerEntity.DateOfBirth = "10/12/1987";
            playerEntity.FullName = "Daniel Podence";
            playerEntity.Height = 183;
            playerEntity.Position = "Winger";
            return playerEntity;
        }

        public string CreatePlayer(PlayerEntity playerEntity)
        {
            playerEntity.Id = Guid.NewGuid().ToString();
            _elasticClient.GetClient().Index(playerEntity, i => i.Index("player"));
            return playerEntity.Id;
        }
    }
}
