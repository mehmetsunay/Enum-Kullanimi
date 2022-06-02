using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {   //Aldığı değeri ekrana vermek için int ekledim
            Console.WriteLine((int)Kategoriler.Elektronik);
            Console.ReadKey();
           
        }


        //Önemli bir yeri vardır çünkü tekrar yazımları kodları engeller Hız ve verim kazandırır
        enum Kategoriler
        {
            Tuhafiye = 3,
            Hırdavat =2,
            Gıda=1,
            Güzellik=4,
            Temizlik = 5

        }

    }

     
}
