using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackInlandTaskController : ControllerBase
    {
        ReassignTrackInlandTaskService _service;


        [Route("")]
        public IActionResult Reassign(Guid taskId, string newAssignee, string oldAssignee)
        {
            _service.Reassign(taskId, newAssignee, oldAssignee);

            return null;
        }
    }
}
