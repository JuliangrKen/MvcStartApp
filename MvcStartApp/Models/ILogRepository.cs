using System.Threading.Tasks;

namespace MvcStartApp.Models
{
    public interface ILogRepository
    {
        Task AddRequest(Request request);
        Task<Request[]> GetLogs();
    }
}
