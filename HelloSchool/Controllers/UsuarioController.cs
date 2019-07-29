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
public class UsuarioController : ControllerBase
{
private readonly PreRegistroContext _context;
public UsuarioController(PreRegistroContext context)
{
_context = context;
if (_context.Usuarios.Count() == 0)
{
// Crea un nuevo item si la coleccion esta vacia,
// lo que significa que no puedes borrar todos los Items.
_context.Usuarios.Add(new Usuario {usuario = "CC", Contraseña = "1003242572", TipoUsuario = "Administrador",Correo="Rodriguez"});
_context.Usuarios.Add(new Usuario {usuario = "TI", Contraseña = "10032315727", TipoUsuario="Visitante",Correo="Paz"});

_context.SaveChanges();
}
}


[HttpGet]
public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
{
return await _context.Usuarios.ToListAsync();
}

[HttpGet("{id}")]
public async Task<ActionResult<Usuario>> GetUsuarios(int id)
{
var usuario = await _context.Usuarios.FindAsync(id);
if (usuario == null)
{
return NotFound();
}
return usuario;
}

[HttpPost]
public async Task<ActionResult<PreRegistro>> PostUsuario(Usuario item)
{
_context.Usuarios.Add(item);
await _context.SaveChangesAsync();
return CreatedAtAction(nameof(GetUsuarios), new { id = item.Id }, item);
}

[HttpPut("{id}")]
public async Task<IActionResult> PutUsuario(int id, Usuario item)
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
public async Task<IActionResult> DeleteUsuario(int id)
{
var usuario = await
_context.Usuarios.FindAsync(id);
if (usuario == null)
{
return NotFound();
}

_context.Usuarios.Remove(usuario);
await _context.SaveChangesAsync();
return NoContent();
}

}
}