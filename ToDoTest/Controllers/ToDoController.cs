using System.Linq;
using System.Web.Mvc;
using ToDoTest.Models;

namespace ToDoTest.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ToDoController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: ToDo
        public ActionResult Index()
        {
            var todoList = _context.ToDoList.ToList();

            return View(todoList);
        }
    }
}