using Microsoft.EntityFrameworkCore;
using REST.Data;
using REST.Entities;
using REST.Interface;

namespace REST.Repastorys;
public class CourseRepastory : ICourseRepastorycs
{
    private readonly AppDbContext _appDbContext;
    public CourseRepastory(AppDbContext appDbContext) => _appDbContext = appDbContext;
    public async Task<Course> CreateCourse(Course course)
    {
        Course course1 = new Course();
        course1.Name = course.Name;
        course1.Description = course.Description;
        course1.Time = course.Time;
        _appDbContext.Courses.Add(course1);
        _appDbContext.SaveChanges();
        return course1;
    }

    public async Task<Course> DeleteCourse(int id)
    {
        var uzrid = await _appDbContext.Courses.FindAsync(id);
        _appDbContext.Courses.Remove(uzrid);
        return uzrid;

    }

    public async Task<List<Course>> GetALlCource()
    {
        var getall = await _appDbContext.Courses.ToListAsync();
        return getall;
    }

    public  async Task<Course> GetbYiD(int id)
    {
        var idget = await _appDbContext.Courses.FindAsync(id);
        return idget;

    }

    public async Task<Course> UpdateCourse(int id, Course course)
    {
        Course curs = new Course();
        curs.Name = course.Name;
        curs.Description = course.Description;
        curs.Time = course.Time;
        _appDbContext.SaveChanges();
        return curs;
    }
}
