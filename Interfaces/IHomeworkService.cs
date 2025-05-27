using ClassCompassAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassCompassAPI.Interfaces
{
    public interface IHomeworkService
    {
        Task<IEnumerable<HomeworkAssignment>> GetAssignmentsAsync();
        Task<HomeworkAssignment> CreateAssignmentAsync(HomeworkAssignment assignment);
        Task<HomeworkSubmission> SubmitHomeworkAsync(HomeworkSubmission submission);
        Task<HomeworkGrade> GradeHomeworkAsync(HomeworkGrade grade);
    }
}