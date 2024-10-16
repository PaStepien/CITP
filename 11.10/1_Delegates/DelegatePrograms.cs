
int[] numbers = [1, 2, 3, 4, 5];


/*

x => x;


*/



//Console.WriteLine(Square(3));

//Transformer t = Square;

//Console.WriteLine(t(4));

//PrintSquareNumber(numbers);
//PrintNumberPlus10(numbers);

var func = Add10;

Func<string, double> func2;

Print(numbers, x => x + 10);

static void Print(int[] numbers, Func<int, int> fn)
{
    foreach (var n in numbers)
    {
        Console.WriteLine(fn(n));
    }
}

static void PrintSquareNumber(int[] numbers)
{
    foreach (var n in numbers)
    {
        Console.WriteLine(Square(n));
    }
}

static void PrintNumberPlus10(int[] numbers)
{
    foreach (var n in numbers)
    {
        Console.WriteLine(Add10(n));
    }
}

static int Add10(int x)
{
    return x + 10;
}

static int Square(int x)
{
    return x * x;
}


delegate int Transformer(int x);

