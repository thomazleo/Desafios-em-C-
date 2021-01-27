using System;

class Program
{
    static void Main(string[] args)

    {
        int quantidadeFigurinhas = int.Parse(Console.ReadLine());
        int FigurinhasCompradas = int.Parse(Console.ReadLine());
        int totalDeFigurinhas = 0;

        int[] albumDeFigurinha = new int[FigurinhasCompradas];

        for (int i = 0; i < FigurinhasCompradas; i++)
        {
            string entrada = Console.ReadLine();
            if (entrada != null)
            {
                albumDeFigurinha[i] = int.Parse(entrada);
            }
        }

        for (int i = 0; i < FigurinhasCompradas; i++)
        {
            int figurinha = albumDeFigurinha[i];
            int repetida = 0;

            for (int j = 0; j < FigurinhasCompradas; j++)
            {
                if (albumDeFigurinha[j] == figurinha)
                {
                    repetida++;
                }
            }

            if (repetida >= 2)
            { 
                for (int j = 0; j < FigurinhasCompradas; j++)
                {
                    if (figurinha == albumDeFigurinha[j])
                    { 
                        albumDeFigurinha[j] = -1;
                        break;
                    }
                }
            }
        }

        int figuras = 0;

        for (int i = 0; i < FigurinhasCompradas; i++)
        {
            if (albumDeFigurinha[i] != -1)
            {
                figuras++;
            }
        }

        totalDeFigurinhas = quantidadeFigurinhas - figuras;

        Console.Write(totalDeFigurinhas);

    }
}