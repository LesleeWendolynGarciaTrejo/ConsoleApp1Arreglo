using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArreglo
{
    class Calificaciones
    {
        private string nombre;
        private string apellidos;
        private string promedio;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Promedio
        {
            get { return promedio; }
            set { promedio = value; }
        }
        public Calificaciones()
        {
            nombre = "";
            apellidos = "";
            Promedio = "";
        }
        public Calificaciones(string nombre, string apellidos, string carrera)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.promedio = carrera;
        }
        public override string ToString()
        {
            return nombre + " " + apellidos + " " + promedio + " ";
        }

    }
}