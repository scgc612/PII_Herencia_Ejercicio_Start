using System;

namespace Library
{
    public class Pasajero: Personas
    {
        public Pasajero(int calificacion) : base(name, lastName, ci, foto)
        {
            this.Calificacion = calificacion;
        }
        private int Calificacion{get;}
    }
}