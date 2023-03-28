using Pruebatest1;
using System.Collections.Generic;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            var alumnos = new List<Alumno>();

            alumnos.Add(new Alumno("Maria"));

            var juan = new Alumno();
            juan.Nombre = "Juan";

            var renata = new Alumno() { Nombre = "Renata" };

            alumnos.Add (renata);
            alumnos.Add ((Alumno)juan);

            Assert.NotNull (alumnos);
            Assert.Equal (3, alumnos.Count);
            Assert.Equal("Maria", alumnos.First().Nombre);
            Assert.Equal("Renata", alumnos[1].Nombre);
            Assert.Equal("Juan", alumnos.Last().Nombre);

        }

        [Theory]
        [InlineData(1000, "Test1")]
        [InlineData(10000, "Test2")]
        [InlineData(100000, "Test3")]

        public void ListaAdd2(int cantidad, string nombreAlumno) 
        {
            var alumnos = new List<Alumno>();

            for (int i = 0; i < cantidad; i++)
            {
                alumnos.Add(new Alumno($"{nombreAlumno} {i}"));
            }

            Assert.NotNull (alumnos);
            Assert.Equal(cantidad, alumnos.Count);
        }
    }
}