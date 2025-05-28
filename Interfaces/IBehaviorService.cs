using System.Threading.Tasks;
using System.Collections.Generic;
using ClassCompassAPI.Data.Models;

namespace ClassCompassAPI.Interfaces
{
    public interface IBehaviorService
    {
        Task RecordBehavior(string studentId, BehaviorRecord record);
        Task<IEnumerable<BehaviorRecord>> GetBehaviorRecords(string studentId);
    }
}