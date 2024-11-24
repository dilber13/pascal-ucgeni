

using System;

class Program
{
    static void Main()
    {
        Console.Write("Pascal üçgeni için satır sayısını girin: ");
        int satirSayisi;

        while (!int.TryParse(Console.ReadLine(), out satirSayisi) || satirSayisi <= 0)
        {
            Console.Write("Geçersiz giriş! Lütfen pozitif bir tamsayı girin: ");
        }

        PascalUcgeniBastir(satirSayisi);
    }

    static void PascalUcgeniBastir(int satirSayisi)
    {
        int[][] pascalUcgeni = new int[satirSayisi][];

        for (int i = 0; i < satirSayisi; i++)
        {
            pascalUcgeni[i] = new int[i + 1];
            pascalUcgeni[i][0] = 1; 
            pascalUcgeni[i][i] = 1; 

            
            for (int j = 1; j < i; j++)
            {
                pascalUcgeni[i][j] = pascalUcgeni[i - 1][j - 1] + pascalUcgeni[i - 1][j];
            }
        }

        
        for (int i = 0; i < satirSayisi; i++)
        {
           
            Console.Write(new string(' ', (satirSayisi - i) * 2));

            for (int j = 0; j <= i; j++)
            {
                
                Console.Write($"{pascalUcgeni[i][j],4}");
            }
            Console.WriteLine();
        }
    }
}