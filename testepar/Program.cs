using System;

namespace testepar
{
    class Program
    {
        static void Main(string[] args)
        {
            Validar numero = new Validar();

            Console.WriteLine("Informe um numero: ");
            numero.verificar(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("O numero e: " + numero.resposta());
        }
    }
}
