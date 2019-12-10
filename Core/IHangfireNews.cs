using System.Threading.Tasks;

namespace Data
{
   public interface IHangfireNews
    {
        Task<bool> TaskNewsAddStart();
    }
}
