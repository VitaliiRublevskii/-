using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_12_23
{
    internal class Square
    {
        private float _sideLength;
        public float SideLength {
            get { return _sideLength; }
            set { 
            if (value > 0)
                    _sideLength = value;
            } }

        
        public int CountSide { get; set; }
        public string Name { get; set; }
        public Color _color { get; set; }

        public int CoordX { get; set; }
        public int CoordY { get; set; }


        


        

        public Square()
        {
            this.SideLength = 0;
            this.CountSide = 4;
            this.Name = string.Empty;
            this.CoordX = 0;
            this.CoordY = 0;
        }
        public Square(float side, string Name, Color color)
        {
            this.SideLength = side;
            this.CountSide = 4;
            this.Name = Name;
            this._color = color;
            this.CoordX = 0;
            this.CoordY = 0;
        }

        public Square(int x, int y) {
            this.CoordX = x;
            this.CoordY = y;
        }

        // метод вывода информации о квадрате
        public string GetInfoSquare()
        {
            return $"Квадрат {this.Name}  имеет {this.CountSide} стороны,\tкаждая сторона имеет длину {this.SideLength}";
        }

        // метод печати квадрата
        public void PrintSquare()
        {
            Console.WriteLine($"Квадрат {this.Name}");
            for (int i = CoordX; i < this.SideLength; i++)
            {
                for (int j = CoordY; j < this.SideLength; j++)
                {
                    
                    if (_color == Color.Green) { Console.ForegroundColor = ConsoleColor.Green;}
                    if (_color == Color.Red) { Console.ForegroundColor = ConsoleColor.Red; }
                    if (_color == Color.Blue) { Console.ForegroundColor = ConsoleColor.Blue; }
                    
                    if (j > 0 && j < (this.SideLength - 1) && i > 0 && i < (this.SideLength - 1))
                    {
                        if (_color == Color.Green) { Console.BackgroundColor = ConsoleColor.Green; }
                        if (_color == Color.Red) { Console.BackgroundColor = ConsoleColor.Red; }
                        if (_color == Color.Blue) { Console.BackgroundColor = ConsoleColor.Blue; }
                        
                        Console.Write("  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        // метод для ввода пользователем названия квадрата, длины стороны и цвета
        public void UserInput () 
        {
            Console.WriteLine("Введите имя квадрата, длинну сторон, цвет квадрата");
            Console.Write("Имя квадрата: ");
            this.Name = Console.ReadLine();
            Console.Write("Длина стороны: ");
            this.SideLength = float.Parse(Console.ReadLine());

            string[] colorNames = { "red", "green", "blue" };
            ConsoleColor[] colorItems = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue };
            int idx = -1, idx1 = 0;
            int userChoose = 0;
            ConsoleKeyInfo keyInfo;
            
            do
            {
                Console.Clear();
                for (int i = 0; i < colorNames.Length; i++)
                {
                    if (userChoose == i)
                    {
                        Console.ForegroundColor = colorItems[i];
                        Console.Write("-->");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.ForegroundColor = colorItems[i];
                    Console.WriteLine(colorNames[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Title = userChoose.ToString();  //  ???
                
                keyInfo = Console.ReadKey();
                
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    userChoose --;
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                    userChoose ++;
                if (userChoose < 0)
                    userChoose = 0;
                if (userChoose >= colorNames.Length || userChoose < 0)
                {
                    idx1 = userChoose % 3;
                    userChoose = idx1;
                }
                idx = userChoose;
                Console.WriteLine($"inx =  {idx},  userChoose = {userChoose}");
                         
            } while ((keyInfo.Key != ConsoleKey.Enter));

            if (userChoose == 0)
                this._color = Color.Red;
            else if (userChoose == 1)
                this._color = Color.Green;
            else if (userChoose == 2)
                this._color = Color.Blue;
        }
    }
}






//Console.ForegroundColor = ConsoleColor.Green;


/*
            //Console.Write("Выберите цвет (1 - зеленый, 2 - красный, 3 - синий:)");
            //int color = int.Parse(Console.ReadLine());
            if (color == 1)
                this._color = Color.Green;
            else if (color == 2)
                this._color = Color.Red;
            else if (color == 3)
                this._color = Color.Blue;*/