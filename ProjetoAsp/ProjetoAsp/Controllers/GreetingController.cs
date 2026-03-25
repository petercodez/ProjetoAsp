using Microsoft.AspNetCore.Mvc;
using ProjetoAsp.Models;

namespace ProjetoAsp.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{

    [HttpGet]
    public Greeting Get()
    {
        return new Greeting(1, "Hello World");
    }
}
