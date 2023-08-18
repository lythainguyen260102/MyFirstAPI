using MyAPI.Entities;
using System.Threading.Tasks;

namespace MyAPI.Interfaces
{
    public interface IAIOService
    {
        Task<AIO> GetAIO();
    }
}
