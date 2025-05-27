using ClassCompassAPI.Models;

namespace ClassCompassAPI.Interfaces
{
    public interface IBehaviorService
    {
        Task<IEnumerable<BehaviorRecord>> GetBehaviorRecordsAsync(int studentId);
        Task<BehaviorRecord> CreateBehaviorRecordAsync(BehaviorRecord record);
    }
}