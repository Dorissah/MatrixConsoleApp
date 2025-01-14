﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4x4Matrix
{
    public class Determinant
    {
        double d = 0;
        public void Entry()
        {
           
            Console.WriteLine("Matrix 4X4 Determinant Finder");
            double[,] mat = new double[7, 7];
            int i, j;
            Console.WriteLine("enter the elements");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nThe Matrix Structure is:");//to show two line spacing "/n"  do the trick
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(mat[i, j] + "");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThe Matrix Determinant is " + Entry(4, mat));
            Console.ReadKey();
        }

        public double Entry(int n, double[,] mat)
        {
            int c, subi, i, j, subj;
            double[,] submat = new double[7, 7];
            if (n == 2)
            {
                return ((mat[0, 0] * mat[1, 1]) - (mat[1, 0] * mat[0, 1]));
            }
            else
            {
                for (c = 0; c < 4; c++)
                {
                    subi = 0;
                    for (i = 1; i < 4; i++)
                    {
                        subj = 0;
                        for (j = 0; j < 4; j++)
                        {
                            if (j == c)
                            {
                                continue;
                            }
                            submat[subi, subj] = mat[i, j];
                            subj++;
                        }
                        subi++;
                    }
                    d = d + (Math.Pow(-1, c) * mat[0, c] * Entry(n - 1, submat));
                }
            }
            return d;

        }
    }
}
