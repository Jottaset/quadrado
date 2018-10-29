using System;
namespace Quadrado
{
    public class Quadrado
    {
        private int lado1;
        private int lado2;
        private int lado3;
        private int lado4;

        public void defineValorLado1(int ValorLado1){
            lado1 = ValorLado1;
        }

        public int getValor1(){
            return lado1;
        }

        public void defineValorLado2(int ValorLado2)
        {
            lado2 = ValorLado2;
        }

        public int getValor2()
        {
            return lado2;
        }

        public void defineValorLado3(int ValorLado3)
        {
            lado3 = ValorLado3;
        }

        public int getValor3()
        {
            return lado3;
        }

        public void defineValorLado4(int ValorLado4)
        {
            lado4 = ValorLado4;
        }

        public int getValor4()
        {
            return lado4;
        }
    }

}
