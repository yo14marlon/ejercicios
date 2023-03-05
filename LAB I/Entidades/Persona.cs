using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Entidades
{
    public class Persona0
    {

        public void calcularIMC1(double peso0, double altura0)
        {
            double Imc0 = peso0 / Math.Pow(altura0, 2);
            
            if(Imc0 >= 25)
            {
                Console.WriteLine("Tienes un IMC de " + Imc0 + "tienes sobrepeso");
            }
            else 
            {
                Console.WriteLine("Tienes un IMC de " + Imc0 + "tienes un peso normal");
            }
            
        }

        public void MayordeEdad(int Edad0, string Nombre0, string Sexo0)
        {
            Console.WriteLine("n" + Nombre0 + "\n" + "Sexo:" +Sexo0 + "\n");
            if(Edad0 >= 18 ) 
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
        }

    }
}
