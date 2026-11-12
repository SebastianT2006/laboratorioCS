using aplicacion_Personas.entidades;
using aplicacion_Personas.implementaciones;
using aplicacion_Personas.interfaces;
using Microsoft.EntityFrameworkCore;
using pruebas_Personas.Nucleo;

namespace pruebas_Personas.Repositorios
{
    [TestClass]
    public class PersonasPrueba
    {
        private readonly IConexion? iConexion;
        private List<Personas>? lista;
        private Personas? entidad;

        public PersonasPrueba()
        {
            iConexion = new Conexion();
        }

        [TestMethod]
        public void Ejecutar()
        {
            Assert.IsTrue(Guardar());
            Assert.IsTrue(Modificar());
            Assert.IsTrue(Listar());
            Assert.IsTrue(Borrar());
        }

        public bool Listar()
        {
            this.lista = this.iConexion!.Personas!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            this.entidad = EntidadesNucleo.Persona()!;

            this.iConexion!.Personas!.Add(this.entidad);
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Modificar()
        {
            var entry = this.iConexion!.Entry<Personas>(this.entidad!);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.Personas!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }
}