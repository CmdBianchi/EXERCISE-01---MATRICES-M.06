using System;
namespace EXERCISE_01___MATRICES_M._06 {
    //-----> START
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            double[,] mat = new double[2, 3]; // ------ > Declação da matriz 

            Console.WriteLine(mat.Length); // ------ > Tamanho da matriz
            Console.WriteLine(mat.Rank); // ------ >  Tamanho da primeira dimensão
            Console.WriteLine(mat.GetLength(0)); // ------ > Tamanho da PRIMEIRA dimensão da matriz 
            Console.WriteLine(mat.GetLength(0)); // ------ > Tamanho da SEGUNDA dimensão da matriz 
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
