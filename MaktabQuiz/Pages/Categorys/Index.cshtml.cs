using MaktabQuiz.Models;
using MaktabQuiz.Ripository.Interfaces;
using MaktabQuiz.Ripository.Ripositorys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabQuiz.Pages.Categorys
{
    public class IndexModel : PageModel
    {
        private ICateguryRipository _categoryRepository;
        public IndexModel(ICateguryRipository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public List<Category> Category { get; set; }
        public void OnGet()
        {
            Category = _categoryRepository.GetAllCategury().Result;
        }
        public async Task<IActionResult> onGetDelete(int id)
        {
            var entity = _categoryRepository.GetCateguryById(id);
            _categoryRepository.DeleteCategury(entity.Id);
            return RedirectToPage("Index");
        }
    }
}
