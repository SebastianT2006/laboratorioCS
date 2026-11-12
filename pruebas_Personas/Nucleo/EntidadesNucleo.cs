using aplicacion_Personas.entidades;

namespace pruebas_Personas.Nucleo
{
    public class EntidadesNucleo
    {
        public static Personas? Persona()
        {
            var entidad = new Personas();
            entidad.Nombre = "N-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Apellido = "A-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.AnioNacimiento = DateTime.Now.AddYears(-30);
            entidad.Genero = "No especificado";
            return entidad;
        }
    }
}
