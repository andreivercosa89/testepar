using System;
namespace testepar
{
    public class Validar
    {
           private string resultado;

            public void verificar (int num)
            {
                if (num % 2 == 0)
                {
                    resultado = "Par";
                }
                else
                {
                    resultado = "Impar";
                }
            }

            public string resposta()
            {
                return resultado;
            }
    }
}
