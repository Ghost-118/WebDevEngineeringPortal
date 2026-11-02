using DevEngineeringHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebDevEngineeringPortal.Models;

namespace WebDevEngineeringPortal.Pages;

public class IndexModel : PageModel
{
    public List<TechLanguage> TechList { get; set; } = new List<TechLanguage>();
    public TechLanguage? SelectedTech { get; set; }

    public void OnGet(string? techId)
    {
        TechList = TechRepository.GetEngineeringTechData();

        if (!String.IsNullOrEmpty(techId))
        {
            SelectedTech = TechList.FirstOrDefault(t => t.Id.ToLower() == techId.ToLower());
        }
    }
}