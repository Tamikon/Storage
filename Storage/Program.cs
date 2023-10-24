using Storage;
using System;
using System.Drawing;

public class Program
{
    public static void Main() // Демонстрация работы склада.
    {
        Warehouse.sofas.Add(new Sofa("YAMAHA", 130, 200, "Экокожа"));
        Warehouse.sofas.Add(new Sofa("Comfort", 100, 170, "Ткань"));

        Warehouse.chairs.Add(new Chair("YAMAHA", "Дубовая древесина"));
        Warehouse.chairs.Add(new Chair("Soft", "Еловая древесина" ));

        Warehouse.GetListOfSofas();
        Warehouse.GetListOfChairs();
    }
}