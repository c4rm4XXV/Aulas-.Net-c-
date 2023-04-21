using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_.Net_C_.Models
{
    public class Calculadora
    {
        public void Somar(double primeiroNumero, double segundoNumero)
        {
            Console.WriteLine($"{primeiroNumero} + {segundoNumero} = {primeiroNumero + segundoNumero}");
        }
        public void Subtrair(double primeiroNumero, double segundoNumero)
        {
            Console.WriteLine($"{primeiroNumero} - {segundoNumero} = {primeiroNumero - segundoNumero}");
        }
        public void Multiplicar(double primeiroNumero, double segundoNumero)
        {
            Console.WriteLine($"{primeiroNumero} * {segundoNumero} = {primeiroNumero * segundoNumero}");
        }
        public void Dividir(double primeiroNumero, double segundoNumero)
        {
            Console.WriteLine($"{primeiroNumero} / {segundoNumero} = {primeiroNumero / segundoNumero}");
        }
        public void Potencia(double @base, double coeficiente)
        {
            double resultado = Math.Pow(@base, coeficiente);
            Console.WriteLine($"{@base} ^ {coeficiente} = {resultado}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * (Math.PI / 180);
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O Seno do angulo {angulo} é {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * (Math.PI / 180);
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O Coseno do angulo {angulo} é {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * (Math.PI / 180);
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"A Tangete do angulo {angulo} é {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada (double x )
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A Raiz quadrada de {x} = {raiz}");
        }
    }
}