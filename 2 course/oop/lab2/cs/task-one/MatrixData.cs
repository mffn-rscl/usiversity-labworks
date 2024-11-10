// MatrixData.cs
using System;
using System.Linq;

public partial class MyMatrix
{
    private double[,] data;

    public MyMatrix(MyMatrix other)
    {
        data = (double[,])other.data.Clone();
    }

    public MyMatrix(double[,] array)
    {
        data = (double[,])array.Clone();
    }

    public MyMatrix(double[][] jaggedArray)
    {
        int rows = jaggedArray.Length;
        int cols = jaggedArray[0].Length;

        if (jaggedArray.Any(row => row.Length != cols))
            throw new ArgumentException("Jagged array is not rectangular.");

        data = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                data[i, j] = jaggedArray[i][j];
    }

    public MyMatrix(string[] rows)
    {
        int numCols = rows[0].Split().Count();

        data = new double[rows.Length, numCols];
        for (int i = 0; i < rows.Length; i++)
        {
            var numbers = rows[i].Split().Select(double.Parse).ToArray();
            if (numbers.Length != numCols)
                throw new ArgumentException("All rows must have the same number of elements.");
            for (int j = 0; j < numCols; j++)
                data[i, j] = numbers[j];
        }
    }

    public MyMatrix(string matrixString)
    {
        var rows = matrixString.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        int numCols = rows[0].Split().Count();

        data = new double[rows.Length, numCols];
        for (int i = 0; i < rows.Length; i++)
        {
            var numbers = rows[i].Split().Select(double.Parse).ToArray();
            if (numbers.Length != numCols)
                throw new ArgumentException("All rows must have the same number of elements.");
            for (int j = 0; j < numCols; j++)
                data[i, j] = numbers[j];
        }
    }

    public int Height => data.GetLength(0);
    public int Width => data.GetLength(1);

    public int GetHeight() => Height;
    public int GetWidth() => Width;

    public double this[int row, int col]
    {
        get
        {
            if (row >= Height || col >= Width)
                throw new IndexOutOfRangeException();
            return data[row, col];
        }
        set
        {
            if (row >= Height || col >= Width)
                throw new IndexOutOfRangeException();
            data[row, col] = value;
        }
    }

    public double GetElement(int row, int col) => this[row, col];
    public void SetElement(int row, int col, double value) => this[row, col] = value;

    public override string ToString()
    {
        return string.Join(Environment.NewLine, Enumerable.Range(0, Height)
            .Select(i => string.Join("\t", Enumerable.Range(0, Width).Select(j => data[i, j].ToString()))));
    }
}
