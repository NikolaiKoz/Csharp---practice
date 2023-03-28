using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebatest1
{
    public class Alumno
    {
        //string _legajo = "nombre";
        public string Nombre { get; set; }

        public Alumno(){}

        public Alumno(string nombre)
        {
            Nombre = nombre;
        }
    }
}
