
using Microsoft.AspNetCore.Mvc;
using YarvizApiHospital.Clases;
using YarvizApiHospital.Services;

namespace YarvizApiHospital.Controllers
{
    [ApiController]
    [Route("api/Medicos")]
    public class MedicosController : ControllerBase
    {
        private readonly MedicoService _medicoService;

        public MedicosController(MedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        [HttpGet("Listar")]
        public IActionResult ListarMedicos()
        {
            var medicos = _medicoService.ObtenerMedicos();
            return Ok(medicos);
        }

        [HttpPost("Crear")]
        public IActionResult CrearMedico([FromBody] Medico nuevoMedico)
        {
            _medicoService.AgregarMedico(nuevoMedico);
            return Ok("Médico creado exitosamente");
        }
    }
}


[ApiController]
[Route("[controller]")]
public class PacientesController : ControllerBase
{
    [HttpGet("Listar")]
    public IActionResult Listar()
    {

        List<Medico> listaPacientes = new List<Medico>();

        return Ok(listaPacientes);
    }

    [HttpPost("Nuevo")]
    public IActionResult NuevoPaciente()
    {
        return Ok("Paciente creado exitosamente");
    }
}

[ApiController]
[Route("[controller]")]
public class CitasController : ControllerBase
{
    [HttpGet("Listar")]
    public IActionResult Listar()
    {

        List<Medico> listaCitas = new List<Medico>();

        return Ok(listaCitas);
    }

    [HttpPost("Nuevo")]
    public IActionResult NuevaCita()
    {

        return Ok("Cita creada exitosamente");
    }
}
