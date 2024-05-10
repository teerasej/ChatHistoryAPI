using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChatHistoryAPI
{
    [ApiController]
    [Route("api/chat")]
    public class ChatHistory : ControllerBase
    {
        [HttpPost("histories")]
        public async Task<IActionResult> SaveChatHistory()
        {
            return Ok();
        }

        [HttpGet("topics")]
        public IActionResult GetTopicsByUserID([FromQuery] string userID)
        {
            return Ok();
        }
    }
}