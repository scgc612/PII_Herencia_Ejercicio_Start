namespace Library
{
    public class DriverPool : Conductores
    {
     public int Cant_Pasajeros{get;}
     public DriverPool(string name, string lastName, string ci,string vehiculo,int calificación, string bio, int Cant_Pasajeros) : base (name,lastName,ci,calificación, vehiculo, bio)
        {
            this.Cant_Pasajeros = Cant_Pasajeros;
        }
    }
}