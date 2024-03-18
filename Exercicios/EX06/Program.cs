using System;

class Program
{
    static void Main(string[] args)
    {
        //     // Cria um vetor de 1000 valores preenchidos automaticamente
        //     int[] vetor = new int[1000];
        //     Random random = new Random();


        //     for (int i = 0; i < vetor.Length; i++)
        //     {
        //         vetor[i] = random.Next(1000); // Preenche o vetor com valores aleatórios de 0 a 999
        //     }

        //     // Ordena o vetor usando o Bubble Sort
        //     BubbleSort(vetor);

        //     // Exibe o vetor ordenado
        //     foreach (int elemento in vetor)
        //     {
        //         Console.Write(elemento + " ");
        //     }
        //     Console.WriteLine();
        // }

        // // Função para ordenar o vetor usando Bubble Sort
        // static void BubbleSort(int[] vetor)
        // {
        //     int n = vetor.Length;
        //     for (int i = 0; i < n - 1; i++)
        //     {
        //         for (int j = 0; j < n - i - 1; j++)
        //         {
        //             if (vetor[j] > vetor[j + 1])
        //             {
        //                 // Troca os elementos vetor[j] e vetor[j+1]
        //                 int temp = vetor[j];
        //                 vetor[j] = vetor[j + 1];
        //                 vetor[j + 1] = temp;
        //             }
        //         }
        //     }



        {
            // Cria um vetor de 1000 valores preenchidos automaticamente
            int[] vetor = new int[100];
            Random random = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1000); // Preenche o vetor com valores aleatórios de 0 a 999
            }

            // Ordena o vetor usando o método Array.Sort (Quick Sort)
            Array.Sort(vetor);

            // Exibe o vetor ordenado
            foreach (int elemento in vetor)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }





    }
}
