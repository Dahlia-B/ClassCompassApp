using System.Threading.Tasks;
using System.Collections.Generic;
using ClassCompassAPI.Data.Models;

namespace ClassCompassAPI.Interfaces
{
    public interface IHomeworkService
    {
        Task AssignHomework(HomeworkAssignment assignment);
        Task GradeHomework(HomeworkGrade grade);
    }
}