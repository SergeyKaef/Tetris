using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TETRIS
{
    internal class Game
    {

        private static readonly Random random = new Random();

        private static readonly int[][][] shapes = new int[][][]
        {
            new int[][] { new int[] {1, 1, 1, 1} }, // I
            new int[][] { new int[] {1, 1}, new int[] {1, 1} }, // O
            new int[][] { new int[] {0, 1, 0}, new int[] {1, 1, 1} }, // T
            new int[][] { new int[] {1, 1, 0}, new int[] {0, 1, 1} }, // Z
            new int[][] { new int[] {0, 1, 1}, new int[] {1, 1, 0} }, // S
            new int[][] { new int[] {1, 0, 0}, new int[] {1, 1, 1} }, // L
            new int[][] { new int[] {0, 0, 1}, new int[] {1, 1, 1} }  // J
        };

        public Figure CurrentFigure { get; private set; }
        public int FigureX { get; private set; }
        public int FigureY { get; private set; }
        public bool GameOver { get; private set; }

        private int[,] grid;

        public Game()
        {
            grid = new int[20, 10];
            SpawnNewFigure();
        }

        public int[,] GetGrid()
        {
            int[,] tempGrid = (int[,])grid.Clone();

            for (int i = 0; i < CurrentFigure.Shape.Length; i++)
                for (int j = 0; j < CurrentFigure.Shape[i].Length; j++)
                    if (CurrentFigure.Shape[i][j] == 1)
                        tempGrid[FigureY + i, FigureX + j] = 1;

            return tempGrid;
        }

        public void MoveFigureDown()
        {
            FigureY++;
            if (IsCollision())
            {
                FigureY--;
                PlaceFigure();
                SpawnNewFigure();
            }
        }

        public void MoveFigureLeft()
        {
            FigureX--;
            if (IsCollision()) FigureX++;
        }

        public void MoveFigureRight()
        {
            FigureX++;
            if (IsCollision()) FigureX--;
        }

        private void PlaceFigure()
        {
            for (int i = 0; i < CurrentFigure.Shape.Length; i++)
                for (int j = 0; j < CurrentFigure.Shape[i].Length; j++)
                    if (CurrentFigure.Shape[i][j] == 1)
                        grid[FigureY + i, FigureX + j] = 1;

            CheckLines();
        }

        private void CheckLines()
        {
            for (int y = 0; y < 20; y++)
            {
                bool fullLine = true;
                for (int x = 0; x < 10; x++)
                {
                    if (grid[y, x] == 0)
                    {
                        fullLine = false;
                        break;
                    }
                }

                if (fullLine)
                {
                    ClearLine(y);
                }
            }
        }

        private void ClearLine(int line)
        {
            for (int y = line; y > 0; y--)
                for (int x = 0; x < 10; x++)
                    grid[y, x] = grid[y - 1, x];

            for (int x = 0; x < 10; x++)
                grid[0, x] = 0;
        }

        private void SpawnNewFigure()
        {
            CurrentFigure = new Figure(shapes[random.Next(shapes.Length)]);
            FigureX = 3;
            FigureY = 0;

            if (IsCollision())
            {
                GameOver = true;
            }
        }

        private bool IsCollision()
        {
            for (int i = 0; i < CurrentFigure.Shape.Length; i++)
            {
                for (int j = 0; j < CurrentFigure.Shape[i].Length; j++)
                {
                    if (CurrentFigure.Shape[i][j] == 1)
                    {
                        int x = FigureX + j;
                        int y = FigureY + i;

                        if (x < 0 || x >= 10 || y >= 20 || grid[y, x] == 1)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
