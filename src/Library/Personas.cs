using System;

namespace Library
{
    public abstract class Personas
    {
        public Personas(string name, string lastName, string ci, string foto)
        {
            this.Name = name;
            this.LastName = lastName;
            this.CI = ci;
            this.Foto = foto;
        }
        public string Name{get;}
        public string LastName{get;}
        public string CI{get;}
        public string Foto{get;}
        public void message(){}

    }
}
