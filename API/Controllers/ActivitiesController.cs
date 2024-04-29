using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{

  [ApiController]
  [Route("[controller]")]
  public class ActivitiesController : ControllerBase
  {
    private readonly DataContext _dataContext;

    public ActivitiesController(DataContext dataContext)
    {
         _dataContext = dataContext;
    }
       // [HttpGet(Name = "GetActivities")]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            List<Domain.Activity> activities = await _dataContext.Activities.ToListAsync();
            return Ok(activities);
        }  
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Activity>>> GetActivity(Guid id)
        {            
            Domain.Activity activity = await _dataContext.Activities.FindAsync(id);
            return Ok(activity);                 
        }      
  }
}