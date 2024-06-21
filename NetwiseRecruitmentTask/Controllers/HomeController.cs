using Microsoft.AspNetCore.Mvc;
using NetwiseRecruitmentTask.Abstractions;

namespace NetwiseRecruitmentTask.Controllers;

public class HomeController : Controller
{
    private readonly ICatFactService _catFactService;
    private readonly ILogger<HomeController> _logger;
    private const string FilePath = "CatFacts.txt";

    public HomeController(ICatFactService catFactService, ILogger<HomeController> logger)
    {
        _catFactService = catFactService;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        string[] catFacts = [];

        try
        {
            if (System.IO.File.Exists(FilePath))
            {
                catFacts = await System.IO.File.ReadAllLinesAsync(FilePath);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error reading CatFacts.txt");
        }

        return View(catFacts);
    }

    [HttpGet]
    public async Task<IActionResult> FetchCatFact()
    {
        try
        {
            var catFact = await _catFactService.GetCatFactAsync();
            var catFactText = $"{catFact.Fact} - Length: {catFact.Length}"; // Dodaj długość do tekstu

            await System.IO.File.AppendAllTextAsync(FilePath, catFactText + Environment.NewLine);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching cat fact");
        }
        return RedirectToAction(nameof(Index));
    }
}