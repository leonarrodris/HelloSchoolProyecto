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
_context.PreRegistros.Add(new PreRegistro {TipoDocumento = "CC", NoDocumento = "1003242572", Nombres = "Leonardo",Apellidos="Rodriguez",Correo= "leonarrodris100@gmail.com",Celular="3116638440",Parentesco="Padre",TipoDocumentoEstudiante="RC",NoDocumentoEstudiante="32131",NombresEstudiante="Leenard",ApellidosEstudiante="Rodriguez",FechaNacimientoEstudiante=27/02/2017 });
_context.PreRegistros.Add(new PreRegistro {TipoDocumento = "TI", NoDocumento = "10032315727", Nombres="Gizah",Apellidos="Paz" ,Correo= "leonarrodris100@gmail.com",Celular= "3023012312",Parentesco="Madre",TipoDocumentoEstudiante="RC",NoDocumentoEstudiante="123123", NombresEstudiante="Leah",ApellidosEstudiante="Rodriguez",FechaNacimientoEstudiante=27/02/2017});

_context.SaveChanges();
}
}


[HttpGet]
public async Task<ActionResult<IEnumerable<PreRegistro>>> GetPreRegistros()
{
return await _context.PreRegistros.ToListAsync();
}

[HttpGet("{id}")]
public async Task<ActionResult<PreRegistro>> GetPreRegistros(int id)
{
var preRegistro = await _context.PreRegistros.FindAsync(id);
if (preRegistro == null)
{
return NotFound();
}
return preRegistro;
}

[HttpPost]
public async Task<ActionResult<PreRegistro>> PostPreRegistro(PreRegistro item)
{
_context.PreRegistros.Add(item);
await _context.SaveChangesAsync();
return CreatedAtAction(nameof(GetPreRegistros), new { id = item.Id }, item);
}

[HttpPut("{id}")]
public async Task<IActionResult> PutPreRegistro(int id, PreRegistro item)
{
if (id != item.Id)
{
return BadRequest();
}
_context.Entry(item).State = EntityState.Modified;
await _context.SaveChangesAsync();
return NoContent();
}

[HttpDelete("{id}")]
public async Task<IActionResult> DeletePreRegistro(int id)
{
var preRegistro = await
_context.PreRegistros.FindAsync(id);
if (preRegistro == null)
{
return NotFound();
}

_context.PreRegistros.Remove(preRegistro);
await _context.SaveChangesAsync();
return NoContent();
}

}
}