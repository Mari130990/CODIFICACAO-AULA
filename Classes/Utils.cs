using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC9_ENTROCO_REMOTO_2.Classes
{
    public class Utils
    {
        public static void BarraCarregamento(string texto, int repetição, string elemento, int temp){
           Console.BackgroundColor = ConsoleColor.DarkMagenta;
           Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine($"texto");
           for (int contador = 0; contador < 6; contador ++)
           {
              Thread.Sleep(500);
              Console.Write($"{elemento}");
           }
           Console.ResetColor();
        }
         
         public static void verificarPastaArquivo(string caminho){
            string pasta = caminho.Split("/")[0];

            if (Directory.Exists(pasta))
            {
              Directory.CreateDirectory(pasta);

             if (!File.Exists(caminho))
             {
               using (File.Create(caminho)){}
             }
            }
         }   
    }
}