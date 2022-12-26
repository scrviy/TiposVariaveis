using System;

namespace TiposVariaveis
{
    public class TiposVariaveis
    {
        public static void Main(string[] args)
        {
            int numero1 = 10; // declara uma variável inteira e armazena valor 10 nela.
            int numero2 = 20; 
            var soma = numero1 + numero2; // o var define dinâmicamente o tipo da variável
            Console.WriteLine("10 + 20 = " + soma);

            int copiaDeNumero1 = numero1; // copia o valor da variável 'numero1'
            copiaDeNumero1 = 11; // valor alterado.
            Console.WriteLine(numero1);
            Console.WriteLine(copiaDeNumero1);

            var quadrado1 = new Quadrado();
            quadrado1.lado = 10;

            var quadrado2 = quadrado1; //referencia?
            quadrado2.lado = 11;
            Console.WriteLine(quadrado1.lado);
            Console.WriteLine(quadrado2.lado);
        }

        class Quadrado // define uma classe chamada Quadrado
        {
            public int lado;
        }
    }
}