using AutoMapper;
using DotNetAndElastic.Data;
using DotNetAndElastic.Entities;
using DotNetAndElastic.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotNetAndElastic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {

        private readonly IPlayersRepository _playersRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public PlayerController(IPlayersRepository playersRepository, ILogger<PlayerController> logger, IMapper mapper)
        {
            _playersRepository = playersRepository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{playerId}")]
        public ActionResult<PlayerViewModel> GetPlayer(int playerId)
        {
            var playerEntity = _playersRepository.GetPlayer(playerId);
            _logger.LogInformation("an elastic search client is instantiated ");

            var mappedPlayerViewModel = _mapper.Map<PlayerViewModel>(playerEntity);

            return Ok(mappedPlayerViewModel);
        }


        [HttpPost()]
        public ActionResult<PlayerViewModel> CreatePlayer(PlayerViewModel playerViewModel)
        {
            var mappedPlayer = _mapper.Map<PlayerEntity>(playerViewModel);

            var newPlayerId  =_playersRepository.CreatePlayer(mappedPlayer);

            var playerCreatedViewModel = new PlayerCreatedViewModel
            {
                PlayerId = newPlayerId
            };

            return CreatedAtAction(nameof(CreatePlayer), new { id = playerCreatedViewModel.PlayerId }, playerCreatedViewModel);
        }

    }
}