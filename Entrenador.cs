using System;

namespace Practica1
{

    class Entrenador: MiembroSeleccionFutbol
    {
        string federacion;

        public string Federacion { get => federacion; set => federacion = value; }

        public Entrenador(string federacion, string nombre, int edad): base(nombre, edad)
        {
            Federacion = federacion;
        }

        public override void Concentrarse()
        {
            Console.WriteLine("El entrenador esta concentrado");
        }
        public override void Entrenar()
        {
            Console.WriteLine($"El entrenador hace parte de la: {federacion}");
        }
        public override void JugarPartido()
        {
            Console.WriteLine($"El entrenador esta pendiente del partido de la: {federacion}");
        }
        public override void Viajar()
        {
            Console.WriteLine($"El entrenador esta viajando con la: {federacion}");
        }

        public void PlanificaEntrenamiento()
        {
            Console.WriteLine("<entrenar> clase: Entrenador");
        }
    }
}
