using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app.Pages;

public class IndexModel : PageModel
{
    public IConfiguration Config { get; }

    public void OnGet()
    {
        ViewData["TestDisplay"] = Config["TestVal"];
    }
    public IndexModel(IConfiguration config)
    {
        Config = config;
    }
}
