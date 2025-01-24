using BusinessApp.Entities;
using BusinessApp.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusinessApp.Controllers
{
    public class JobsController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IJobRepository _jobRepository;
        private readonly IJobTypeRepository _jobTypeRepository;
        private readonly IUserRepository _userRepository;
        public JobsController(IJobRepository jobRepository, ICategoryRepository categoryRepository, IJobTypeRepository jobTypeRepository, IUserRepository userRepository)
        {
            _jobRepository = jobRepository;
            _categoryRepository = categoryRepository;
            _jobTypeRepository = jobTypeRepository;
            _userRepository = userRepository;
        }

        public async Task<IActionResult> Index()
        {
            var jobs = await _jobRepository.GetAllJobsAsync();
            return View(jobs);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = new SelectList(await _categoryRepository.GetAllAsync(), "Id", "Name");
            ViewBag.JobTypes = new SelectList(await _jobTypeRepository.GetAllAsync(), "Id", "Type");
            ViewBag.Users = new SelectList(await _userRepository.GetAllAsync(), "Id", "FullName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Job job)
        {
            await _jobRepository.AddAsync(job);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var job = await _jobRepository.GetByIdJobAsync(id);

            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }
    }
}