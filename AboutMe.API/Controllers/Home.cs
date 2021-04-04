using AboutMe.Domain.Abstract;
using AboutMe.Domain.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AboutMe.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Home : ControllerBase
    {
        private readonly IMyInfo _myInfo;
        public Home(IMyInfo myInfo)
        {
            _myInfo = myInfo;
        }
        [EnableCors("AllowOrigin")]
        [HttpGet]
        public async Task<MyInfo> Get()
        {
            MyInfo info = await _myInfo.myInfo();
            return info;
        }
    }
}
