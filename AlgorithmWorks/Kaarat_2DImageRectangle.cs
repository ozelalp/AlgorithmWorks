using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmWorks
{
    public record Rectangle(int Row, int Column, int Width, int Height);
    public static class Kaarat_2DImageRectangle
    {

        public static int[][] image1 = new int[][]
        {
            new int[] {1, 1, 1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 0, 0, 0, 1},
            new int[] {1, 1, 1, 0, 0, 0, 1},
            new int[] {1, 1, 1, 1, 1, 1, 1}
        };
        public static int[][] image2 = new int[][]
        {
            new int[] {1, 1, 1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1, 0, 0},
            new int[] {1, 1, 1, 1, 1, 0, 0}
        };

        public static int[][] image3 = new int[][]
        {
            new int[] {1, 1, 1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1, 0, 1},
            new int[] {1, 1, 1, 1, 1, 1, 1}
        };

        public static int[][] image4 = new int[][]
        {
            new int[] {1, 1, 1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1, 1, 0}
        };

        public static int[][] image5 = new int[][]
        {};

        public static int[][] image6 = new int[][]
        { new int[] {0} };


        public static Rectangle FindRectangle(int[][] image)
        {
            if (image == null || image.Length == 0 || image[0].Length == 0)
            {
                return new Rectangle(-1, -1, -1, -1); // No rectangle found
            }

            int rowI = -1, colI = -1, width = -1, height = -1;
            int rowIndex = image.Length;
            int columnIndex = image[0].Length;
            for (int i = 0; i < rowIndex; i++)
            {
                //Array.FindIndex(image[i], f => f == 0); // Ensure the row is processed
                //Array.IndexOf(image[i], 0); // Ensure the row is processed  
                //image[i].FirstOrDefault(f => f == 0); // Ensure the row is processed
                for (int j = 0; j < columnIndex; j++)
                {
                    if (image[i][j] == 0)
                    {
                        rowI = i;
                        colI = j;
                        width = FindWidth(i, j, image);
                        height = FindHeight(i, j, image);
                        break;
                    }
                }

                if (rowI != -1)
                    break; // Break outer loop if rectangle found
            }

            if (rowI == -1 || colI == -1)
            {
                return new Rectangle(-1, -1, -1, -1); // No rectangle found
            }

            return new Rectangle(rowI, colI, width, height);

            //public int[][] FindRectangle_CoPilot(int[][] image)
            //{
            //    if (image == null || image.Length == 0 || image[0].Length == 0)
            //    {
            //        return new int[0][];
            //    }
            //    int rows = image.Length;
            //    int cols = image[0].Length;
            //    int top = -1, bottom = -1, left = -1, right = -1;
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            if (image[i][j] == 0)
            //            {
            //                if (top == -1) top = i;
            //                if (bottom == -1 || i > bottom) bottom = i;
            //                if (left == -1 || j < left) left = j;
            //                if (right == -1 || j > right) right = j;
            //            }
            //        }
            //    }
            //    if (top == -1) return new int[0][]; // No rectangle found
            //    return new int[][]
            //    {
            //        new int[] { top, left },
            //        new int[] { bottom, right }
            //    };
            //}

        }

        private static int FindWidth(int i, int j, int[][] image)
        {
            if (image[0].Length == j + 1)
                return 1;

            for(int k = j+1; k < image[0].Length; k++)
            {
                if (image[i][k] != 0)
                {
                    return k - j;
                }
            }

            return image[0].Length - j; // rest are all 0s
        }

        private static int FindHeight(int i, int j, int[][] image)
        {
            if (image.Length == i + 1)
                return 1;

            for (int k = i + 1; k < image.Length; k++)
            {
                if (image[k][j] != 0)
                {
                    return k - i;
                }
            }

            return image.Length - i; // rest are all 0s
        }

        internal class RectangleClass
        {
            public int Row { get; set; }
            public int Column { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public RectangleClass(int row, int column, int width, int height)
            {
                Row = row;
                Column = column;
                Width = width;
                Height = height;
            }
        }
    }
}
