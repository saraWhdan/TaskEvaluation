using Microsoft.AspNetCore.Mvc;
using TaskEvaluation.Core.Entities.DTOs;
using TaskEvaluation.Core.Interfaces.IServices;
using TaskEvaluation.Infrastructure.Services;

namespace TaskEvaluation.Web.Controllers
{

    public class AssignmentController : Controller
    {
        private readonly IAssignmentService _assignmentService;
        public AssignmentController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        public async Task<IActionResult> Index()
        {
            var course = await _assignmentService.GetAssignmentsAsync();
            return View(course);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AssignmentDTO assignmentDTO)
        {
            if (ModelState.IsValid)
            {
                await _assignmentService.CreateAsync(assignmentDTO);
                return RedirectToAction(nameof(Index));
            }
            return View(assignmentDTO);
        }
        public async Task<IActionResult> Details(int id)
        {
            var course = await _assignmentService.GetAssignmentAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var course = await _assignmentService.GetAssignmentAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AssignmentDTO assignmentDTO)
        {
            if (id != assignmentDTO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _assignmentService.UpdateAsync(assignmentDTO);
                return RedirectToAction(nameof(Index));
            }
            return View(assignmentDTO);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var course = await _assignmentService.GetAssignmentAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _assignmentService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
