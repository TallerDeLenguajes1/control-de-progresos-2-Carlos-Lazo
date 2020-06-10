using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public enum Maximos
        {
            Velocidad = 10,
            Destreza =10,
            Nivel = 10,
            Fuerza = 10,
            Armadura = 10,
            Salud= 100,
            Daño = 50

        }
    enum Tipos
        {
            Mago = 0,
            Guerrero = 1,
            Elfo = 2,
            Ada = 3,
            Enano = 4

        }
    public class Personaje
    {

        private string nombre;
        private string apodo;
        private DateTime fechanacimiento;
        private int edad;
        private int salud;
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;
        private int daño;

        private string[] tipo = { "Ada", "Mago", "Guerrero", "Enano", "Orco" };
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public string[] Tipo { get => tipo; set => tipo = value; }
        public int Daño { get => daño; set => daño = value; }

        public int CalculoEdad(DateTime Fecha)
        {
            int Edad;

            Edad = DateTime.Now.Year - Fechanacimiento.Year;

            return Edad;
        }

        public void Cargardatos(string _Nombre, string _Apodo, DateTime _Fecha)

        {
            Random rand = new Random();

            Nombre = _Nombre;
            Apodo = _Apodo;
            Fechanacimiento = _Fecha;
            Edad = CalculoEdad(_Fecha);
            Velocidad = rand.Next(Convert.ToInt32(Maximos.Velocidad));
            Destreza = rand.Next(Convert.ToInt32(Maximos.Destreza));
            Fuerza = rand.Next(Convert.ToInt32(Maximos.Fuerza));
            Nivel = rand.Next(Convert.ToInt32(Maximos.Nivel));
            Armadura = rand.Next(Convert.ToInt32(Maximos.Armadura));
            Salud = rand.Next(Convert.ToInt32(Maximos.Salud));
            Daño = rand.Next(Convert.ToInt32(Maximos.Daño));


        }

        public string[] MostrarDatos()
        {

            string[] ficha = { Nombre, Apodo, Convert.ToString(Fechanacimiento), Convert.ToString(Edad), Convert.ToString(Velocidad), Convert.ToString(Destreza), Convert.ToString(Fuerza), Convert.ToString(Nivel), Convert.ToString(Armadura) };

            return ficha;


        }

        public void Atacar(Personaje _personaje)
        {

            int PoderDisparo = Destreza * Fuerza * Nivel;
            int Efectividad = (new Random().Next(100) + 1) / 100;
            int ValorAtaque = PoderDisparo * Efectividad;
            int PoderDefensa = _personaje.Armadura * _personaje.Velocidad;
            int DañoTotal = ((ValorAtaque * Efectividad - PoderDefensa) / Convert.ToInt32(Maximos.Daño)) * 100;

            _personaje.Salud -= DañoTotal;
        }

        
        


    }
}
