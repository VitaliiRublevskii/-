


using System.Drawing;
using Lesson_04_12_23;

Square sq1 = new Square(10, "Big", Color.Green);
Console.WriteLine(sq1.GetInfoSquare());
sq1.PrintSquare();

Square sq2 = new Square();

sq2.UserInput();

sq2.PrintSquare();



char[,] matrix = new char[50, 50];

ConsoleKeyInfo keyInfo;

while (Console.ReadKey().Key != ConsoleKey.Enter)
{
    ClearMatrix(matrix);
    
    DrawInMatrix(sq2, matrix);
    
    DrawMatrix(matrix);
    
    keyInfo = Console.ReadKey();
    
    if (keyInfo.Key == ConsoleKey.D)
    {
        sq2.CoordX++;
    }
    if (keyInfo.Key == ConsoleKey.A)
    {
        sq2.CoordX--;
    }
    if (keyInfo.Key == ConsoleKey.W)
    {
        sq2.CoordY--;
    }
    if (keyInfo.Key == ConsoleKey.S)
    {
        sq2.CoordY++;
    }
   


}

static void DrawInMatrix(Square square, char[,] matrix)
{
    for (int i = 0; i < square.SideLength; i++)
    {
        for (int j = 0; j < square.SideLength; j++)
        {
            if (square != null)
            {
                matrix[square.CoordX + i, square.CoordY + j] = '*';
            }

        }
    }

}

static void DrawMatrix(char[,] matrix)
{
    //Console.Clear();
    for (int i = 0; i < 50; i++)
    {
        for (int j = 0; j < 50; j++)
        {
            Console.Write(matrix[j, i]);
        }
        Console.WriteLine();
    }
}
static void ClearMatrix(char[,] matrix)
{
    for (int i = 0; i < 49; i++)
    {
        for (int j = 0; j < 49; j++)
        {
            matrix[i, j] = ' ';
        }
    }
}




