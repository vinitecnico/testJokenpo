using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testJokenpo.Entities;
using testJokenpo.Repository;

namespace testJokenpo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IRepository _gameRepository;

        public GameController(IRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        // GET api/game/{player1}/{player2}
        [HttpGet("{player1}/{player2}")]
        public string Get(TypeGame.type player1, TypeGame.type player2)
        {
            return _gameRepository.WinningPlay(player1.ToString(), player2.ToString());
        }
    }
}
