using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_elseif_ternary_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın!");
            }
            else if (time >= 11 && time <= 18)
            {
                Console.WriteLine("iyi Günler");

            }
            else
            {
                Console.WriteLine("İyi geceler");
            }
                string sonuc = time <= 18 ? "İyi günler" : "İyi geceler";
            sonuc = time >= 6 && time <= 11 ? "Günaydın" : time >= 11 && time <= 18 ? "İyi günler" : "İyi geceler";
                Console.WriteLine(sonuc);
            
        }

    }
}
