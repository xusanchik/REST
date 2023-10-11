using REST.Entities;

namespace REST.Interface
{
    public interface ICourseRepastorycs
    {
        Task<List<Course>> GetALlCource();
        Task<Course> GetbYiD(int id);
        Task<Course> CreateCourse(Course course);
        Task<Course> UpdateCourse(int id , Course course);
        Task<Course> DeleteCourse(int id);

    }
}
