using aplicacion_Personas.entidades;
using aplicacion_Personas.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace servicies_Personas.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PersonasController : ControllerBase
    {
        private IPersonasAplicacion personasAplicacion;

        public PersonasController(IPersonasAplicacion personasAplicacion)
        {
            this.personasAplicacion = personasAplicacion;
        }

        [HttpPost]
        public List<Personas> Consultar()
        {
            return this.personasAplicacion.Consultar();
        }

        [HttpPost]
        public List<Personas> Buscar(Personas entidad)
        {
            return this.personasAplicacion.Buscar(entidad);
        }

        [HttpPost]
        public Personas Insertar(Personas entidad)
        {
            return this.personasAplicacion.Insertar(entidad);
        }

        [HttpPost]
        public Personas Actualizar(Personas entidad)
        {
            return this.personasAplicacion.Actualizar(entidad);
        }

        [HttpPost]
        public Personas Borrar(Personas entidad)
        {
            return this.personasAplicacion.Borrar(entidad);
        }
    }
}
