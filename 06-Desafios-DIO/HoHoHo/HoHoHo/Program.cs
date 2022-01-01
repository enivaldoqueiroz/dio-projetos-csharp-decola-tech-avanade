using System;

namespace HoHoHo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desafio C# - 1 / 5 - Ho Ho Ho

            int N = int.Parse(Console.ReadLine());

            //Exibir "Ho" do papai noel
            for (int i = 0; i <= N; i++)
            {
                if (i < (N - 1))
                {
                    Console.Write("Ho ");                  //Complete o código no espaço em branco
                }
                else if (i == N)
                {
                    Console.WriteLine("Ho!");
                }
            }
        }
    }
}
