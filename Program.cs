//Beni Yaratan Elbet Yolumu Gösterir .Şuara78
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu programlar ile kullandığımız değişkenlerin min ve max'ta alacağı değerleri bulmayı hedefleriz.

            Console.WriteLine("İnteger :");
            Console.WriteLine("İnt Max Değeri :" + " " + int.MaxValue);
            Console.WriteLine("İnt Min Değeri :" + " " + int.MinValue);

            Console.WriteLine();

            Console.WriteLine("Float :");
            Console.WriteLine("Float Max Değeri :" + " " + float.MaxValue);
            Console.WriteLine("Float Min Değeri :" + " " + float.MinValue);

            Console.WriteLine();

            Console.WriteLine("Double :");
            Console.WriteLine("Double Max Değeri :" + " " + double.MaxValue);
            Console.WriteLine("Double Min Değeri :" + " " + double.MinValue);

            Console.WriteLine();

            Console.WriteLine("Byte :");
            Console.WriteLine("Byte Max Değeri :" + " " + byte.MaxValue);
            Console.WriteLine("Byte Min Değeri :" + " " + byte.MinValue);

            Console.WriteLine();

            Console.WriteLine("Sbyte :");
            Console.WriteLine("Sbyte Max Değeri :" + " " + sbyte.MaxValue);
            Console.WriteLine("Sbyte Min Değeri :" + " " + sbyte.MinValue);

            Console.Read();

        }
    }
}
