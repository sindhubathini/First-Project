using AboutMe.Domain.Entities;
using System.Threading.Tasks;

namespace AboutMe.Domain.Abstract
{
    public interface IMyInfo
    {
        Task<MyInfo> myInfo();
    }
}
