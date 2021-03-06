﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOAP {
    class Program {
        static void Main(string[] args) {
            // Создаем и инициализируем рандом для генерации ID
            Random rnd = new Random();
            
            // Создаем и инициализируем объекты класса "Pen".
            Pen MyPen1 = new Pen(rnd.Next(0, 10000), ConsoleColor.DarkYellow, 20);
            Pen MyPen2 = new Pen(rnd.Next(0, 10000), 21);
            
            // Эмуляция написания ручкой.
            MyPen1.WriteText("The written text");
            MyPen1.WriteText("The written text");
            MyPen2.WriteText("The written text");
            // Изменяем поле отвечающее за цвет.
            Console.WriteLine("Manually changed colour to Cyan");
            MyPen2.Color = ConsoleColor.Cyan;
            MyPen2.WriteText("The written text");

            Console.WriteLine();
            Console.WriteLine("Для проверки работы деструктора нажмите Enter");
            Console.ReadLine();

            // Проверка работы деструктора.
            for (int i = 0; i < 100000; i++) {
                // Создаем большое количество ненужных объектов для вызова работы сборщика мусора.
                MyPen1 = new Pen(rnd.Next(0, 10000), ConsoleColor.DarkYellow, 20);
                MyPen2 = new Pen(rnd.Next(0, 10000), 21);
            }
            // Вод ля завершения программы.
            Console.ReadLine();
        }
    }
}
