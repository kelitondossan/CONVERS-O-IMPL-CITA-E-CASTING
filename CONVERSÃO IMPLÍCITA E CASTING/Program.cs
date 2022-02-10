using System;

namespace CONVERSÃO_IMPLÍCITA_E_CASTING
{
    class Program
    {
        static void Main(string[] args)
        {
            float X = 4.5F;
            double Y = X;
            Console.WriteLine(Y);
            // FAZENDO COVERSÃO IMPLÍCITA   LOGO A BAIXO
            Console.WriteLine("-----------------------------------\n");
            double A;
            float B;

            A = 5.1;
            B = (float) A; // CONVERETE DOUBLE PARA FLOAT PERDENDO INFORMAÇÃO POIS A VARIAVEL DOUBLE TEM 8 BYTES E ESTOU TENTANDO COLOCAR  ELE EM FLOAT QUE SO ARMAZENA 4 BYTS RESULTADO VAI DAR CERTO POREM PODESE PERDER INFORMAÇÃO
            Console.WriteLine(B);


            Console.WriteLine("------\n");
            double d;
            int f;
            d = 6.7;
            f = (int) d;
            Console.WriteLine(f);
            //  
            Console.WriteLine("-------------\n");
            Console.WriteLine("PROGRAMINHA SEM CONVERSÃO ");

            int a = 5;
            int b = 2;

            double resultado = (a / b);// REPARA QUE O VALOR IMPRIMIDO VAI SER O NUMERO 2 POREM TERIA QUE IMPRIME  2.5
            Console.WriteLine(resultado);

            //REPARE AGORA QUE VAI SER IMPRIMIR O NUMERO 2.5
            //CORREÇÃO  DE SITAX 
            Console.WriteLine("----------------");
            Console.WriteLine("PROGRAMINHA COM CONVERSÃO ");
            Console.WriteLine("-------------\n");
            int _a = 5;
            int _b = 2;

            double resul= (double)_a / _b;
            Console.WriteLine(resul);

        }
    }
}
