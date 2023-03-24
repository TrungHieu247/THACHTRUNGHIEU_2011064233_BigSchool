using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;
using ThachTrungHieu_2011064233.DTOs;
using ThachTrungHieu_2011064233.Models;

namespace ThachTrungHieu_2011064233.Controllers
{
    public class FollowingsController : ApiController
    {
            private readonly ApplicationDbContext _dbContext;
            public FollowingsController()
            {
                _dbContext = new ApplicationDbContext();
            }
            [HttpPost]
            public IHttpActionResult Follow(FollowingDto followingDto)
            {
                var userId = User.Identity.GetUserId();
                if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                    return BadRequest("Following already exists!");

                var folowing = new Following
                {
                    FollowerId = userId,
                    FolloweeId = followingDto.FolloweeId
                };
                _dbContext.Followings.Add(folowing);
                _dbContext.SaveChanges();

                return Ok();
            }
        
    }
}
