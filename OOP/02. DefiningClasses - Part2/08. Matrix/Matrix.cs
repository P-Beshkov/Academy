/*08. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
09. Implement an indexer this[row, col] to access the inner matrix cells.
10. Implement the operators + and - (addition and subtraction of matrices of the same size) 
* and * for matrix multiplication. Throw an exception when the operation cannot be performed. 
* Implement the true operator (check for non-zero elements). */

using System;
using System.Collections.Generic;

class Matrix<T> where T: struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    int[,] matrix;
    private int rows;
    private int columns;
    
    public int Columns
    {
        get
        {
            return this.columns;
        }
        set
        {
            this.columns = value;
        }
    }
    
    public int Row
    {
        get
        {
            return this.rows;
        }
        set
        {
            this.rows = value;
        }
    }

    public int this[int row, int col]
    {
        get
        {
            return matrix[row, col];
        }
        set
        {
            matrix[row, col] = value;
        }
    }

    public Matrix(int rows, int columns)
    {
        this.Row = rows;
        this.Columns = columns;
        matrix = new int[Row, Columns];
    }

    static public void ToString(Matrix<T> m)
    {
        for (int row = 0; row < m.Row; row++)
        {
            for (int cols = 0; cols < m.Columns; cols++)
            {
                Console.Write("{0,4}", m[row, cols]);
            }
            Console.WriteLine();
        }
    }

    static public Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
    {
        if (m1.Row != m2.Row || m1.Columns != m2.Columns)
        {
            Console.WriteLine("Matrixes must be same size!");
            return null;
        }
        else
        {
            Matrix<T> result = new Matrix<T>(m1.Row, m1.Columns);
            for (int row = 0; row < m1.Row; row++)
            {
                for (int col = 0; col < m1.Columns; col++)
                {
                    result[row, col] = m1[row, col] + m2[row, col];
                }
            }
            return result;
        }
    }

    static public Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
    {
        if (m1.Row != m2.Row || m1.Columns != m2.Columns)
        {
            Console.WriteLine("Matrixes must be same size!");
            return null;
        }
        else
        {
            Matrix<T> result = new Matrix<T>(m1.Row, m1.Columns);
            for (int row = 0; row < m1.Row; row++)
            {
                for (int col = 0; col < m1.Columns; col++)
                {
                    result[row, col] = m1[row, col] - m2[row, col];
                }
            }
            return result;
        }
    }

    static public Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
    {
        Matrix<T> result = new Matrix<T>(m1.Row, m2.Columns);
        if (m1.Columns != m2.Row)
        {
            Console.WriteLine("Error");                
        }
        else
        {
            for (int row = 0; row < m1.Row; row++)
            {
                for (int cols = 0; cols < m2.Columns; cols++)
                {
                    for (int i = 0; i < m1.Columns; i++)
                    {
                        result[row, cols] += m1[row, i] * m2[i, cols];
                    }
                }
            }
        }
        return result;
    }

    public void InicializeMatrix()
    {
        for (int row = 0; row < this.Row; row++)
        {
            for (int cols = 0; cols < this.Columns; cols++)
            {
                Console.Write("[{0},{1}] = ", row, cols);
                matrix[row, cols] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
    }
}