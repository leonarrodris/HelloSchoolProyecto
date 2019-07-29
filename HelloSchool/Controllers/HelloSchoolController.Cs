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
_context.PreRegistros.Add(new PreRegistro { Id = 1, TipoDocumento = "CC", NoDocumento = "1003242572", Nombres = "Leonardo",Apellidos="Rodriguez",Correo= "leonarrodris100@gmail.com",Celular="3116638440",Parentesco="Padre",TipoDocumentoEstudiante="RC",NoDocumentoEstudiante="32131",NombresEstudiante="Leenard",ApellidosEstudiante="Rodriguez",FechaNacimientoEstudiante=27/02/2017 });
_context.PreRegistros.Add(new PreRegistro { Id = 2, TipoDocumento = "TI", NoDocumento = "10032315727", Nombres="Gizah",Apellidos="Paz" ,Correo= "leonarrodris100@gmail.com",Celular= "3023012312",Parentesco="Madre",TipoDocumentoEstudiante="RC",NoDocumentoEstudiante="123123", NombresEstudiante="Leah",ApellidosEstudiante="Rodriguez",FechaNacimientoEstudiante=27/02/2017});
_context.SaveChanges();
}
}

[HttpGet]
public async Task<ActionResult<IEnumerable<PreRegistro>>> GetPreRegistros()
{
return await _context.PreRegistros.ToListAsync();
}

}
}