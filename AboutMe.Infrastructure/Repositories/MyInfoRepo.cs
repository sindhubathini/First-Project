using AboutMe.Domain.Abstract;
using AboutMe.Domain.Entities;
using System.Threading.Tasks;

namespace AboutMe.Infrastructure.Repositories
{
    public class MyInfoRepo : IMyInfo
    {
        public async Task<MyInfo> myInfo()
        {
            MyInfo myInfo = new MyInfo();
            myInfo.Name = "My Name is Sindhu";
            return myInfo;
        }
    }
}
