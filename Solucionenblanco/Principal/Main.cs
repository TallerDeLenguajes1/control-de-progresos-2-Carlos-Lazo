using Entidad;
using System;
using System.Collections.Generic;

namespace Principal
{
    class Entrada
    {   
       
        static void Main(string[] args)
        {
            Personaje player;
            List<Personaje> ListaPersonajes = new List<Personaje>();

            int CantidadPersonajes = new Random().Next(10);
            string[] OPNombres = { "Juan", "Pedro", "Carlos", "Enzo"};
            string[] OPApodo = { "Destructor", "Malo", "Rapido", "Ultimo" };

            for (int i = 0; i < CantidadPersonajes; i++)
            {
                player = new Personaje();

                string nombre = OPNombres[new Random().Next(OPNombres.Length)];
                string apodo = OPApodo[new Random().Next(OPApodo.Length)];
                DateTime Fecha = Helper.FechaAleAtoria(450);

                player.Cargardatos(nombre, apodo, Fecha);
                ListaPersonajes.Add(player);
            }
            Personaje Personaje1 = ListaPersonajes[1];
            Personaje Personaje2 = ListaPersonajes[2];

            for (int i = 0; i < 3; i++)
            {
                Personaje1.Atacar(Personaje2);
                Personaje2.Atacar(Personaje1);
            }

            if (Personaje1.Salud > Personaje2.Salud)
            {
                ListaPersonajes.Remove(Personaje2);
                Personaje1.Salud = Convert.ToInt32(Maximos.Salud);
                Personaje1.Salud += 10;
            }
            else if (Personaje1.Salud < Personaje2.Salud)
            {
                ListaPersonajes.Remove(Personaje1);
                Personaje2.Salud = Convert.ToInt32(Maximos.Salud);
                Personaje2.Salud += 10;
            }
        }
    }
}
