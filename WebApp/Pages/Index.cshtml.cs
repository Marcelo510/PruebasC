using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HtmlAgilityPack;

namespace WebApp.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;

    }

    public async void OnGet()
    {
        var url = "https://www.minutouno.com/";

        var httpclient = new HttpClient();
        var html = await httpclient.GetStringAsync(url);
        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(html);
        ViewData["Pagina"] = htmlDocument;
    }

    public async void OnSet()
    {
        var url = "https://www.minutouno.com/";

        var httpclient = new HttpClient();
        var html = await httpclient.GetStringAsync(url);
        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(html);
        ViewData["Pagina"] = htmlDocument;
    }
}
