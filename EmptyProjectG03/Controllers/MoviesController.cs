using EmptyProjectG03.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmptyProjectG03.Controllers
{
    public class MoviesController : Controller //MVC Controller // ControllerBase API Controller
    {
        [NonAction]
        public void DeleteMovie()
        {
        }

        public string Index()
        {
            return "Hello From Index";
        }

        #region EX01
        // baseUrl/Movies/GetMovie/10
        //[HttpPost]
        //[HttpGet]
        //public ContentResult GetMovie(int? id, string name)
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = $"Movie Id: {id}</br>, Name: {name}";
        //    result.ContentType = "text/html";
        //    //result.ContentType = "text/plain";
        //    result.StatusCode = 600;
        //    return result;
        //    //return $"Movie Id: {id}, Name: {name}";
        //} 
        #endregion

        public IActionResult GetMovie(int id, string name)
        {
            if (id == 0)
            {

                // Bad Request
                //return new BadRequestResult();
                return BadRequest();
            }
            else if (id <= 10)
                return NotFound();
            else
                return Content($"Movie Id = {id}, Name = {name}");
        }
        public IActionResult TestRedirect()
        {
            return RedirectToRoute("Default", new { Controller = "Movies", Action = "GetMovie" });
            //return RedirectToAction(nameof(GetMovie), "Movies", new { Id = 10, name = "Hamada" });
            //return Redirect("https://www.google.com/");
        }
        [HttpPost]
        public IActionResult TestModelBinding([FromRoute] int id, string name)
        {
            return Content($"Hello {name}, With Id: {id}");
        }

        public IActionResult AddMovie(int Id, Movie movie, string Title) // [FromHeader] not working on complix data only simple Data.
        {
            if (movie is null) return BadRequest();
            return Content($"Movie Id: {movie.Id}, Title: {movie.Title}");
        }

        public IActionResult TestCollection(int[] arr)
        {
            return Content("Test");
        }
    }
}
