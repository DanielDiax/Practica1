namespace Practica1
{
    public abstract class MiembroSeleccionFutbol
    {
        string nombre;
        int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public MiembroSeleccionFutbol(string nombre, int edad) 
        {
            Nombre = nombre;

            Edad = edad;
        }

        public MiembroSeleccionFutbol() 
        { 
        
        }

        public abstract void Concentrarse();

        public abstract void Viajar();

        public abstract void Entrenar();

        public abstract void JugarPartido();
    }
}
