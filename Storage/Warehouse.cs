using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Storage
{
    public class Warehouse // склад мебели
    {
        public static List<Sofa> sofas = new List<Sofa>();     //Списки, имитирующие отделы разной мебели.
        public static List<Chair> chairs = new List<Chair>();  //В них можно будет "загружать" мебель с уникальными параметрами.

        public static void GetListOfSofas() //Отображение списка диванов на складе с описанием.
        {
            Console.WriteLine("Список товаров в отделе \"Диваны\":");
            foreach (Sofa sofa in sofas)
            {
                Console.WriteLine("Диван " + sofa.Firm + ", " +
                    "длина в см: " + sofa.Length + ", ширина в см: " + 
                    sofa.Width + ", материал: " + sofa.Material);
            }
            Console.WriteLine();
        }

        public static void GetListOfChairs() //Отображение списка стульев на складе с описанием.
        {
            Console.WriteLine("Список товаров в отделе \"Стулья\":");
            foreach (Chair chair in chairs)
                Console.WriteLine("Стул " + chair.Firm + " , материал: " + chair.Material);
            Console.WriteLine();
        }
    }
}
