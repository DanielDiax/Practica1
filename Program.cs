using System;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {

            Futbolista futbolista = new Futbolista();
            MiembroSeleccionFutbol[] miembroSeleccion = new MiembroSeleccionFutbol[3];



            //MiembroSeleccionFutbol miembroSeleccion = new MiembroSeleccionFutbol("Daniel", 28);



            miembroSeleccion[0] = new Futbolista(10, "Delantero","Daniel", 28);
            miembroSeleccion[1] = new Futbolista(8, "Defensa","Camilo", 48);
            miembroSeleccion[2] = new Entrenador("FCF", "Marisol", 36);


            foreach (var miembro in miembroSeleccion)
            {
                //Console.WriteLine(Convert.ToString(miembro.GetType()));
                if(Convert.ToString(miembro.GetType()) == "Practica1.Futbolista")
                {
                    Console.WriteLine($"El Futbolita {miembro.Nombre}:");
                    miembro.Concentrarse();
                    miembro.Viajar();
                    miembro.Entrenar();
                    miembro.JugarPartido();
                    futbolista.Entrevista();
                }
                else
                {
                    Console.WriteLine($"\n\n----------");
                    Console.WriteLine($"El Entrenador {miembro.Nombre}:");
                    miembro.Concentrarse();
                    miembro.Viajar();
                    miembro.Entrenar();
                    miembro.JugarPartido();
                }
                
            }
        }
    }
}
