using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloSchool.Models;
namespace HelloSchool.Controllers
{
[Route("api/[controller]")]
[ApiController]
public class HelloSchoolController : ControllerBase
{
private readonly PreRegistroContext _context;
public HelloSchoolController(PreRegistroContext context)
{
_context = context;
if (_context.PreRegistros.Count() == 0)
{
// Crea un nuevo item si la coleccion esta vacia,
// lo que significa que no puedes borrar todos los Items.
_context.PreRegistros.Add(new PreRegistro { Id = 1, TipoDocumento = "CC", NoDocumento = "1003242572", Nombres = "Leonardo",Apellidos="Rodriguez" });
_context.PreRegistros.Add(new PreRegistro { Id = 2, TipoDocumento = "TI", NoDocumento = "10032315727", Nombres="Gizah",Apellidos="Paz" });
_context.SaveChanges();
}
}

// Aquí, despues del constructor de la clase, irán los Métodos HTTP GET,POST, DELETE, PUT

}
}