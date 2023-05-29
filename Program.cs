using System;
namespace Aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que tenha um método para calcular o valor de co-seno de x através dos 25 primeiros
            termos da seguinte série:
                CO-SENO(x) = 1 -(x²/2!)+(x^4/4!)-(x^6/6!)+(x^8/8!)*/
           int x;
           double total;
           Console.WriteLine("Digite um valor: ");
           x = int.Parse(Console.ReadLine());
           total = coseno(x);
           Console.WriteLine("Total: "+total.ToString("F"));
        }
        static double coseno(int intro){
            double x=1;
            for(int i=1; i<=2;i++){
                double termo = (Math.Pow(intro,2*i)/fatorial(2*i));
            if(i % 2 == 0){
                x -=termo;
            }else{
                x+=termo;
            }
            }
            return x;
        }

        static int fatorial(int f){
            int fatorial = 1;
            for(int i=2;i<=f;i++){
                fatorial *= i;
            }
            return fatorial;
        }

    }
}