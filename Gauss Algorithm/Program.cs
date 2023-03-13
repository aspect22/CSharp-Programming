double[,] numbers = new double[2, 3];
double[,] temparray = new double[2, 3];
double y, x;

// Function to read in the numbers
void _ReadNumbers_()
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"Enter number in index {i}{j} number: ");
            numbers[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

// Function to print the numbers
void _PrintNumbers_()
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void _MergeArrayToNumbers_()
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = temparray[i, j];
        }
    }
}

//Print temp array
void _PrintTempArray_()
{
    for (int i = 0; i < temparray.GetLength(0); i++)
    {
        for (int j = 0; j < temparray.GetLength(1); j++)
        {
            Console.Write(temparray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double _AddNumbers_(double numA, double numB)
{
    return numA + numB;
}

double _MultiplyNumbers_(double numA, double numB)
{
    return numA * numB;
}

double _devideNumbers_(double numA, double numB)
{
    return numA / numB * 100;
}

_ReadNumbers_();
_PrintNumbers_();

// Row 1
temparray[0, 0] = _MultiplyNumbers_(numbers[1, 0], numbers[0, 0]);
temparray[0, 1] = _MultiplyNumbers_(numbers[1, 0], numbers[0, 1]);
temparray[0, 2] = _MultiplyNumbers_(numbers[1, 0], numbers[0, 2]);

// Row 2
numbers[0, 0] = numbers[0, 0] - (numbers[0, 0] * 2);
temparray[1, 0] = _MultiplyNumbers_(numbers[0, 0], numbers[1, 0]);
temparray[1, 1] = _MultiplyNumbers_(numbers[0, 0], numbers[1, 1]);
temparray[1, 2] = _MultiplyNumbers_(numbers[0, 0], numbers[1, 2]);

Console.WriteLine("--------------------");
_PrintTempArray_();
_MergeArrayToNumbers_();

// Calculation Row 2
temparray[1, 0] = _AddNumbers_(numbers[1, 0], numbers[0, 0]);
temparray[1, 1] = _AddNumbers_(numbers[1, 1], numbers[0, 1]);
temparray[1, 2] = _AddNumbers_(numbers[1, 2], numbers[0, 2]);

Console.WriteLine("--------------------");
_PrintTempArray_();
_MergeArrayToNumbers_();


// Calculate y 
y = _devideNumbers_(numbers[1, 1], numbers[1, 2]);
Console.WriteLine("--------------------");
Console.WriteLine(y);

// Calculation x
x = ((numbers[0, 1] * y) - numbers[0, 2]) / numbers[0, 0];
x = x * -1;
Console.WriteLine(x);