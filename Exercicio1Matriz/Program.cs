
internal class Program
{
    private static void Main(string[] args)
    {
        double[,] matriz = new double[5,3];
        double soma = 0, media = 0;

        for(int linhas =0; linhas < 5; linhas++)
        {
            Console.WriteLine("DIGITE OS ELEMENTOS DA " + (linhas + 1) + " º LINHA");
            for(int colunas = 0; colunas < 2; colunas++)
            {
                Console.WriteLine("DIGITE OS ELEMENTOS DA " + (colunas + 1) + " º COLUNA");
                {
                    matriz[linhas,colunas] = double.Parse(Console.ReadLine());
                }
            }
        }

        for(int linhas = 0;linhas < 5;linhas++) 
        {
            soma = 0;
            media = 0;
            for(int colunas = 0; colunas < 3;colunas++)
            {
                if(colunas < 2)
                {
                    soma += matriz[linhas, colunas];
                }
                else
                {
                    media = soma / 2;
                    matriz[linhas, colunas] = media;
                }
            }
        }

        for(int linhas = 0; linhas < 5; linhas++)
        {
            for(int colunas = 0; colunas < 3; colunas++)
            {
                if(colunas < 2)
                {
                    Console.Write(matriz[linhas, colunas] + " ");
                }
                else
                {
                    Console.Write("MÉDIA: " + matriz[linhas, colunas].ToString("F2"));
                    Console.WriteLine();
                }
            }
        }

    }
}