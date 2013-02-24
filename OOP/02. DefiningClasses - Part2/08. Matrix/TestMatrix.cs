class TestMatrix
{
    static void Main(string[] args)
    {
        Matrix<decimal> m1 = new Matrix<decimal>(2, 3);
        Matrix<decimal> m2 = new Matrix<decimal>(3, 2);
        m1.InicializeMatrix();
        m2.InicializeMatrix();
        Matrix<decimal> result = m1 * m2;
        Matrix<decimal>.ToString(result);
    }
}