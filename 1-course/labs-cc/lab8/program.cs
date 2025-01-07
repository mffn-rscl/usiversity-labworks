using System;
using System.Text; 

class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        System.Console.WriteLine("LABWORK №8\t OPTION 15");
        Console.WriteLine("\n Оберіть задачу:\nBlock one - 1;\nBlock two - 2;\nBlock thee- 3;\nBlock four - 4;\n");

        int choice = Convert.ToInt32(Console.ReadLine()); 
        
        switch (choice)
        {
            case 1:
                System.Console.WriteLine("Вставити після кожного парного (за значенням) елемента елемент зі значенням 0");
                int[] inputArray = InputArray(); 
                BlockOne(ref inputArray); 
                break;

            case 2:
                break;

            case 3:
                int[][] matrix=  new int[3][]; 
                matrix[0] = new int[11]{1, 4, 6, 7, 3, 2 ,1, 1 ,1, 1,14};
                matrix[1] = new int[5]{7, 3 ,1, 1,14};
                matrix[2] = new int[6]{1, 4, 6, 7, 3, 2};

                BlockThree(ref matrix); 

                break;

            case 4:
                int[] inputFirstArray = InputArray(); 
                int[] inputSecondArray   = InputArray();
                BlockFour(inputFirstArray, inputSecondArray); 
                break;

            default:
                System.Console.WriteLine("Invalid input. Try again.");
                break;
        }
    }

    private static void BlockOne(ref int[] array)
    {
        int counter = 0;
        int arraySize = array.Length; 
        for (int i = 0; i < arraySize; i++) if (array[i] % 2 == 0)counter++;

        int[] solution = new int[counter + arraySize];

        for (int i = 0, j = 0; i < arraySize; i++, j++)
        {
            solution[j] = array[i];
            if (array[i] % 2 == 0)
            {
                j++;
                solution[j] = 0;

            }
        }
        OutputArray(solution); 
    }

    private static void BlockTwo()
    {

    }
    private static void BlockThree(ref int[][] matrix)
    {
      int[] firstRow = matrix[0];
      int len = firstRow.Length;
      int splitLen = len/2;
      int[] firstHalf = new int[splitLen];
      int[] secondHalf = new int[len-splitLen];
      if (len > 10)
      {
        Array.Copy(firstRow, 0, firstHalf, 0, splitLen);
        Array.Copy(firstRow, splitLen, secondHalf, 0,secondHalf.Length);
      } 

      for (int i = matrix.Length-1; i>0; i--)matrix[i] = matrix[i-1]; 
      matrix[0] = firstHalf;
      Array.Resize(ref matrix, matrix.Length);
      for (int i = matrix.Length - 1; i > 0; i--)matrix[i] = matrix[i - 1];
      
      matrix[1] = secondHalf;
      OutputMatrixArray(matrix);
    }

    private static void BlockFour(int[] matrix1, int[] matrix2)
    {
    int cols = matrix1.Length;
    int rows = matrix2.Length;

    int[][] solution = new int[cols][];
    for (int i = 0; i < cols; i++)
    {
        solution[i] = new int[rows];
        for (int j = 0; j < rows; j++)solution[i][j] = matrix1[i] + matrix2[j];
    }

    System.Console.WriteLine("\nКвадратна матриця, сформована із сум елементів i-тої matrix1 та j-тої matrix2: ");
    OutputMatrixArray(solution);

    int[][] transposedSolution = new int[rows][];
    for (int i = 0; i < rows; i++)
    {
        transposedSolution[i] = new int[cols];
        for (int j = 0; j < cols; j++)transposedSolution[i][j] = solution[j][i];
    }

    System.Console.WriteLine("\nТранспонована матриця: ");
    OutputMatrixArray(transposedSolution);
    for (int i = 0; i < rows; i++)Array.Reverse(transposedSolution[i]);

    int[] temp = transposedSolution[0];
    transposedSolution[0] = transposedSolution[rows - 1];
    transposedSolution[rows - 1] = temp;


    System.Console.WriteLine("\nКінцевий результат: ");
    OutputMatrixArray(transposedSolution);
    }

    
   private static void OutputMatrixArray(int[][] array)
{
    System.Console.WriteLine("Результат: ");
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            System.Console.Write($"{array[i][j]} ");
        }
        Console.WriteLine();
    }
}


private static void OutputArray(int[] array)
    {
        System.Console.Write("Результат: ");
        foreach (var item in array) { Console.Write($"{item} "); }
        Console.WriteLine();
    }
    private static int[] InputArray()
    {
        Console.Write("Введіть сукупність чисел:");
        return Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
    }
}


