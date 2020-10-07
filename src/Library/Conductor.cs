using System;

namespace Library
{
    public class Conductor:Personas
    {
        public int CalificacionC{get;}
        public string Bio{get;}
        public string Vehiculo{get;}

        private Conductor(string name, string lastname, string ci, string foto, int calificacionC, string bio, string vehiculo)
        :base(name, lastname, ci, foto)
        {
           this.CalificacionC= calificacionC;
           this.Bio=bio;
           this.Vehiculo=vehiculo;

        }
        public void levantar(pasajero pasajero)
        {
            System.Console.WriteLine($"El {pasajero} esta solicitando ser levantado");
        }
    }
}