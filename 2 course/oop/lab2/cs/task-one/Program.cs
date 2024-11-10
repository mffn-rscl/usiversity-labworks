using System;

class Program
{
    static void Main()
    {
        double[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        MyMatrix matrix1 = new MyMatrix(array);
        Console.WriteLine("Matrix1 (initialized from 2D array):");
        Console.WriteLine(matrix1);

        double[][] jaggedArray = new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } };
        MyMatrix matrix2 = new MyMatrix(jaggedArray);
        Console.WriteLine("Matrix2 (initialized from jagged array):");
        Console.WriteLine(matrix2);

        string matrixString = "1 2 3\n4 5 6\n7 8 9";
        MyMatrix matrix3 = new MyMatrix(matrixString);
        Console.WriteLine("Matrix3 (initialized from string):");
        Console.WriteLine(matrix3);

        Console.WriteLine("Element at (1, 1) in Matrix1: " + matrix1[1, 1]);
        matrix1[1, 1] = 10;
        Console.WriteLine("Updated Matrix1 after setting element (1, 1) to 10:");
        Console.WriteLine(matrix1);

        MyMatrix matrix4 = new MyMatrix(array); 
        MyMatrix sumMatrix = matrix1 + matrix4;
        Console.WriteLine("Sum of Matrix1 and a copy of Matrix1:");
        Console.WriteLine(sumMatrix);

        MyMatrix productMatrix = matrix1 * matrix2;
        Console.WriteLine("Product of Matrix1 and Matrix2:");
        Console.WriteLine(productMatrix);

        MyMatrix transposedMatrix = matrix1.GetTransponedCopy();
        Console.WriteLine("Transposed Matrix1:");
        Console.WriteLine(transposedMatrix);

        matrix1.TransponeMe();
        Console.WriteLine("Matrix1 after TransponeMe():");
        Console.WriteLine(matrix1);

        double determinant = matrix3.CalcDeterminant();
        Console.WriteLine("Determinant of Matrix3:");
        Console.WriteLine(determinant);

        Console.WriteLine("Matrix3 using ToString:");
        Console.WriteLine(matrix3.ToString());
    }
}
