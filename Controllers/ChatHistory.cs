using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatHistoryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatHistoryAPI
{
    [ApiController]
    [Route("api/chat")]
    public class ChatHistory : ControllerBase
    {
        private readonly ChatAppContext _context;

        public ChatHistory(ChatAppContext context)
        {
            _context = context;
        }

        [HttpPost("histories")]
        public async Task<IActionResult> SaveChatHistory([FromBody] Topic topic)
        {
            _context.Topics.Add(topic);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("topics/{userID}")]
        public IActionResult GetTopicsByUserID([FromRoute] string userID)
        {   
            return Ok(new { userId = userID });
        }
    }
}