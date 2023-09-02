using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class  Futbolista : MiembroSeleccionFutbol
    {
        int numeroCamiseta;
        string nemarcacion;

        public int NumeroCamiseta { get => numeroCamiseta; set => numeroCamiseta = value; }
        public string Demarcacion { get => nemarcacion; set => nemarcacion = value; }


        public Futbolista()
        {

        }

        public Futbolista(int numeroCamiseta, string demarcacion, string nombre, int edad): base( nombre,  edad)
        {
            NumeroCamiseta = numeroCamiseta;

            Demarcacion = demarcacion;
        }
        
        public override void Concentrarse()
        {
            Console.WriteLine("El futbolista esta concentrado");
        }

        public override void Entrenar()
        {
            Console.WriteLine($"El Futbolista entrena de: {Demarcacion}");
        }

        public override void JugarPartido()
        {
            Console.WriteLine($"El Futbolista juega con la camiseta n°: {NumeroCamiseta}");
        }

        public override void Viajar()
        {
            
        }

        public void Entrevista()
        {
            Console.WriteLine("<Entrevista()> Futbolista");
        }

    }
}
