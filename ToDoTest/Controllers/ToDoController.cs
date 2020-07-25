using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;
using ToDoTest.Models;
using ToDoTest.ViewModel;

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

        public ActionResult Create()
        {
            var viewModel = new ToDoViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(ToDoViewModel viewModel)
        {
            var todo = new ToDoModel()
            {
                ToDo = viewModel.ToDo,
                DueDate = viewModel.GetDueDate(),
                UserId = User.Identity.GetUserId()
            };


            _context.ToDoList.Add(todo);
            _context.SaveChanges();

            return RedirectToAction("Index", "ToDo");
        }
    }
}