//06.* Write a class Matrix, to holds a matrix of integers. Overload the 
//operators for adding, subtracting and multiplying of matrices, indexer
//for accessing the matrix content and ToString().

using System;

class Program
{ 
    class Matrix
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

        static public void ToString(Matrix m)
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

        static public Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.Row != m2.Row || m1.Columns != m2.Columns)
            {
                Console.WriteLine("Matrixes must be same size!");
                return null;
            }
            else
            {
                Matrix result = new Matrix(m1.Row, m1.Columns);
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

        static public Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.Row != m2.Row || m1.Columns != m2.Columns)
            {
                Console.WriteLine("Matrixes must be same size!");
                return null;
            }
            else
            {
                Matrix result = new Matrix(m1.Row, m1.Columns);
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

        static public Matrix operator *(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(m1.Row, m2.Columns);
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

    
    static void Main()
    {
        Matrix m1 = new Matrix(2, 3);        
        Matrix m2 = new Matrix(3, 2);
        m1.InicializeMatrix();
        m2.InicializeMatrix();
        Matrix result = m1 * m2;
        Matrix.ToString(result);
    }
}