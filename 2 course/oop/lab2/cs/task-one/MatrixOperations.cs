using System;

public partial class MyMatrix
{
    public static MyMatrix operator +(MyMatrix a, MyMatrix b)
    {
        if (a.Height != b.Height || a.Width != b.Width)
            throw new ArgumentException("Matrices must have the same dimensions for addition.");

        double[,] result = new double[a.Height, a.Width];
        for (int i = 0; i < a.Height; i++)
            for (int j = 0; j < a.Width; j++)
                result[i, j] = a[i, j] + b[i, j];
        
        return new MyMatrix(result);
    }

    public static MyMatrix operator *(MyMatrix a, MyMatrix b)
    {
        if (a.Width != b.Height)
            throw new ArgumentException("Invalid matrix dimensions for multiplication.");

        double[,] result = new double[a.Height, b.Width];
        for (int i = 0; i < a.Height; i++)
            for (int j = 0; j < b.Width; j++)
                for (int k = 0; k < a.Width; k++)
                    result[i, j] += a[i, k] * b[k, j];
        
        return new MyMatrix(result);
    }

    private double[,] GetTransponedArray()
    {
        double[,] transposed = new double[Width, Height];
        for (int i = 0; i < Height; i++)
            for (int j = 0; j < Width; j++)
                transposed[j, i] = data[i, j];
        
        return transposed;
    }

    public MyMatrix GetTransponedCopy() => new MyMatrix(GetTransponedArray());

    public void TransponeMe() => data = GetTransponedArray();

    public double CalcDeterminant()
    {
        if (Height != Width)
            throw new InvalidOperationException("Determinant is only defined for square matrices.");

        return CalculateDeterminant(data);
    }

    private double CalculateDeterminant(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        if (n == 1) return matrix[0, 0];
        if (n == 2) return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        double determinant = 0;
        for (int p = 0; p < n; p++)
        {
            double[,] minor = GetMinor(matrix, 0, p);
            determinant += matrix[0, p] * CalculateDeterminant(minor) * (p % 2 == 0 ? 1 : -1);
        }

        return determinant;
    }

    private double[,] GetMinor(double[,] matrix, int row, int col)
    {
        int n = matrix.GetLength(0);
        double[,] minor = new double[n - 1, n - 1];
        for (int i = 0, mi = 0; i < n; i++)
        {
            if (i == row) continue;
            for (int j = 0, mj = 0; j < n; j++)
            {
                if (j == col) continue;
                minor[mi, mj++] = matrix[i, j];
            }
            mi++;
        }
        return minor;
    }
}
