using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using REST.Entities;
using REST.Interface;

namespace REST.Contoller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepastorycs _courseRepastorycs;
        public CourseController(ICourseRepastorycs courseRepastorycs) => _courseRepastorycs = courseRepastorycs;

        [HttpGet]
        public async Task<IActionResult> GetAllCourse() => Ok(_courseRepastorycs.GetALlCource());
        [HttpGet("id")]
        public async Task<IActionResult> GetCourse(int id) => Ok(_courseRepastorycs.GetbYiD(id));
        [HttpPost]
        public async Task<IActionResult> CreateCourse(Course course) => Ok(_courseRepastorycs.CreateCourse(course));
        [HttpPut]
        public async Task<IActionResult> UpdateCourse(int id, Course course) => Ok(_courseRepastorycs.UpdateCourse(id,course));
        [HttpDelete]
        public async Task<IActionResult> DeleteCourse(int id) => Ok(_courseRepastorycs.DeleteCourse(id));



    }
}
