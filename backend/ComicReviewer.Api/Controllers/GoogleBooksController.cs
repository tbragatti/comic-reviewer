using ComicReviewer.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

namespace ComicReviewer.Api.Controllers;
 
[ApiController] 
[Route("api/[controller]")] 
public class GoogleBooksController : ControllerBase
{
    private readonly IConfiguration _configuration; 
    private readonly HttpClient _client; 
    public GoogleBooksController(IConfiguration configuration, HttpClient client) 
    {
        _configuration = configuration;
        _client = client;
    }

    [HttpGet] 
    public async Task<IActionResult> GetComics([FromBody]string query)
    {
        var url = _configuration.GetValue<string>("GoogleBooks:BaseUrl");
        var apiKey = _configuration.GetValue<string>("API_KEY_GOOGLE");

        var urlFinal = $"{url}?q={query}&key={apiKey}";

        var response = await _client.GetAsync(urlFinal);

        if(response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            GoogleResponse quadrinho = JsonSerializer.Deserialize<GoogleResponse>(content);

            return Ok(quadrinho);
        }

       if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            return NotFound();
        }

        return Ok(response);
    }
     
}
