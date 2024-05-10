using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatHistoryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("histories/{userID}/topics")]
        public async Task<IActionResult> GetTopicsByUserID([FromRoute] string userID)
        {
            var topics = await _context.Topics
                .Include(t => t.Messages)
                .Where(t => t.UserID == userID)
                .ToListAsync();

            return Ok(topics);
        }
    }
}