using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDIrCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Creator creator = new Creator();

            // Console.WriteLine(creator.Fractional(10));
            // creator.Fractional(500);         

            //   creator.CreateFolders("c:/temp/test/",1,5,10);
            // Make Parallel Directory + populate h:200 v 200



            // Make XML TREE-




            // proces parallel files



            FindPath(0, 0, 'S');

            Console.ReadLine();
        }


        static char[,] lab =
          { { ' ', ' ', ' ', '*', ' ', ' ', ' ' },
        { '*', '*', ' ', '*', ' ', '*', ' ' },
        { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
        { ' ', '*', '*', '*', '*', '*', ' ' },
        { ' ', ' ', ' ', ' ', ' ', ' ', 'e' }, };

        static char[] path = new char[lab.GetLength(0) * lab.GetLength(1)];
        static int position = 0;

        static void FindPath(int row, int col, char direction)
        {
            if ((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            { // We are out of the labyrinth 
                FindPath(0, 0, 'S');
                return;
            }


            // Append the direction to the path 
            path[position] = direction;
            position++;
            // Check if we have found the exit 
            if (lab[row, col] == 'e')
            { PrintPath(path, 1, position - 1); }
            if (lab[row, col] == ' ')
            {
                // The current cell is free. Mark it as visited 
                lab[row, col] = 's';
                // Invoke recursion to explore all possible directions 
                FindPath(row, col - 1, 'L');
                // left 
                FindPath(row - 1, col, 'U');
                // up 
                FindPath(row, col + 1, 'R');
                // right 
                FindPath(row + 1, col, 'D');
                // down 
                // Mark back the current cell as free 
                lab[row, col] = ' ';
            }
            // Remove the last direction from the path
            position--;
        }
        static void PrintPath(char[] path, int startPos, int endPos)
        {
            Console.Write("Found path to the exit: ");
            for (int pos = startPos; pos <= endPos; pos++)
            { Console.Write(path[pos]); }
            Console.WriteLine();
        }





    }
}