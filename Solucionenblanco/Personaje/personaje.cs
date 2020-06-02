using System;

namespace Personajes
{
    class personaje
    {
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;

        private string tipo;
        private string nombre;
        private string apodo;
        private int fechaN;
        private int edad;
        private int salud;

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public int FechaN { get => fechaN; set => fechaN = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
    }
}
