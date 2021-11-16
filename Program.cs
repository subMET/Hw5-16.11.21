int[] CreateIncreaseArray(int N)
{
    int[] A = new int[N];
    for (int i = 0; i < N; i++)
    {
        A[i] = i + 1;
    }
    return A;
}

int[] CreateIncreaseArrayEven(int N)
{
    int N2 = N / 2;
    int[] A = new int[N2];
    for (int i = 0; i < N2; i++)
    {
        A[i] = 2 * i + 2;
    }
    return A;
}

void PrintArray(int[] A)
{
    int L = A.Length;
    for (int i = 0; i < L; i++)
    {
        Console.Write($"{A[i]} ");
    }
    System.Console.WriteLine();
}

// 23.Показать таблицу квадратов чисел от 1 до N
// int[] SquareTable(int N)
// {
//     int[] A = CreateIncreaseArray(N);
//     int[] B = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         B[i] = A[i] * A[i];
//     }
//     return B;
// }

// bool TestSquareTable() //test 23
// {
//     int N = 3;              // 1 2 3  4  5
//     int[] A = { 1, 4, 9 }; // 1 4 9 16 25
//     int[] B = SquareTable(N);
//     for (int i = 0; i < N; i++)
//     {
//         if (A[i] != B[i])
//         {
//             return false;
//         }
//     }
//     return true;
// }

// int N = 9; //use 23
// int[] B = SquareTable(N);
// PrintArray(B);
// if (TestSquareTable()) { Console.WriteLine("Программа прошла тест."); }
// else { Console.WriteLine("Программа прошла тест."); }

// 24.Найти кубы чисел от 1 до N
// int[] ThirdPowerTable(int N)
// {
//     int[] A = CreateIncreaseArray(N);
//     int[] B = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         B[i] = A[i] * A[i] * A[i];
//     }
//     return B;
// }

// bool TestThirdPowerTable() //test 24
// {
//     int N = 3;              // 1 2 3  4  5
//     int[] A = { 1, 8, 27 }; // 1 8 27 64 125
//     int[] B = ThirdPowerTable(N);
//     for (int i = 0; i < N; i++)
//     {
//         if (A[i] != B[i])
//         {
//             return false;
//         }
//     }
//     return true;
// }

// int N = 5; //use 24
// int[] B = ThirdPowerTable(N);
// PrintArray(B);
// Console.WriteLine();
// if (TestThirdPowerTable()) { Console.WriteLine("Программа прошла тест."); }
// else { Console.WriteLine("Программа не прошла тест."); }

// 25.Найти сумму чисел от 1 до А
// int SumOfNumbers(int A)
// {
//     int Sum = 0;
//     for (int i = 0; i < A; i++)
//     {
//         Sum = Sum + i + 1;
//     }
//     return Sum;
// }

// bool TestSumOfNumbers() //test 25
// {
//     int A1 = 4;
//     int B1 = 10;
//     int A2 = 10;
//     int B2 = 55;
//     int A3 = 8;
//     int B3 = 36;
//     int C1 = SumOfNumbers(A1);
//     int C2 = SumOfNumbers(A2);
//     int C3 = SumOfNumbers(A3);
//     if (B1 == C1 & B2 == C2 & B3 == C3) { return true; }
//     else { return false; }
// }

// int Sum = SumOfNumbers(10);
// Console.WriteLine(Sum);
// if (TestSumOfNumbers()) { Console.WriteLine("Программа прошла тест."); }
// else { Console.WriteLine("Программа не прошла тест."); }

// 26.Возведите число А в натуральную степень B используя цикл
// int ToPower(int A, int B)
// {
//     int Res = 1;
//     for (int i = 0; i < B; i++)
//     {
//         Res = Res * A;
//     }
//     return Res;
// }

// bool TestToPower() //test 26
// {
//     int A1 = 1;
//     int A2 = 4;
//     int A3 = 7;
//     int B1 = 8;
//     int B2 = 3;
//     int B3 = 5;
//     int C1 = 1;
//     int C2 = 64;
//     int C3 = 16807;
//     int D1 = ToPower(A1, B1);
//     int D2 = ToPower(A2, B2);
//     int D3 = ToPower(A3, B3);
//     if (D1 == C1 & D2 == C2 & D3 == C3) { return true; }
//     else { return false; }
// }

// int C = ToPower(2, 8);
// Console.WriteLine(C);
// if (TestToPower()) { Console.WriteLine("Программа прошла тест."); }
// else { Console.WriteLine("Программа не прошла тест."); }

// 27.Определить количество цифр в числе
// int NumbersIn(int A)
// {
//     int count = 0;
//     string B = Convert.ToString(A);
//     count = B.Length;
//     if (A < 0) { count = count - 1; }
//     return count;
// }

// bool TestNumbersIn() //test 27
// {
//     int A1 = 9937;
//     int A2 = -873;
//     int A3 = 5;
//     int B1 = 4;
//     int B2 = 3;
//     int B3 = 1;
//     int C1 = NumbersIn(A1);
//     int C2 = NumbersIn(A2);
//     int C3 = NumbersIn(A3);
//     if (B1 == C1 & B2 == C2 & B3 == C3) { return true; }
//     else { return false; }
// }

// int A = NumbersIn(0);
// System.Console.WriteLine(A);
// if (TestNumbersIn()) { Console.WriteLine("Программа прошла тест."); }
// else { Console.WriteLine("Программа не прошла тест."); }

// 28.Подсчитать сумму цифр в числе
// int SumOfNumbersIn(int A)
// {
//     int Sum = 0;
//     string B = Convert.ToString(A);
//     int L = B.Length;
//     char c;
//     string d;
//     int e;
//     for (int i = 0; i < L; i++)
//     {
//         c = B[i];
//         e = Convert.ToInt32(c);
//         if (e >= 49 & e <= 57)
//         {
//             d = Convert.ToString(c);
//             e = Convert.ToInt32(d);
//             Sum = Sum + e;
//         }
//     }
//     return Sum;
// }

// bool TestSumOfNumbersIn() //test 28
// {
//     int A1 = 9937;
//     int A2 = -873;
//     int A3 = 5;
//     int B1 = 28;
//     int B2 = 18;
//     int B3 = 5;
//     int C1 = SumOfNumbersIn(A1);
//     int C2 = SumOfNumbersIn(A2);
//     int C3 = SumOfNumbersIn(A3);
//     if (B1 == C1 & B2 == C2 & B3 == C3) { return true; }
//     else { return false; }
// }

// int A = SumOfNumbersIn(-93129);
// System.Console.WriteLine(A);
// if (TestSumOfNumbersIn()) { Console.WriteLine("Программа прошла тест."); }
// else { Console.WriteLine("Программа не прошла тест."); }

// 29.Написать программу вычисления произведения чисел от 1 до N
// int Factorial(int A)
// {
//     int Sum = 1;
//     for (int i = 0; i < A; i++)
//     {
//         Sum = Sum * (i + 1);
//     }
//     return Sum;
// }

// bool TestFactorial() //test 29
// {
//     int A1 = 3;
//     int A2 = 8;
//     int A3 = 5;
//     int B1 = 6;
//     int B2 = 40320;
//     int B3 = 120;
//     int C1 = Factorial(A1);
//     int C2 = Factorial(A2);
//     int C3 = Factorial(A3);
//     if (B1 == C1 & B2 == C2 & B3 == C3) { return true; }
//     else { return false; }
// }

// int A = Factorial(5);
// Console.WriteLine(A);
// if (TestFactorial()) { Console.WriteLine("Программа прошла тест."); }
// else { Console.WriteLine("Программа не прошла тест."); }

// 30.Показать кубы чисел, заканчивающихся на четную цифру
// int[] ThirdPowerTableEven(int N)
// {
//     int[] A = CreateIncreaseArrayEven(N);
//     int N2 = N / 2;
//     int[] B = new int[N2];
//     for (int i = 0; i < N2; i++)
//     {
//         B[i] = A[i] * A[i] * A[i];
//     }
//     return B;
// }

// bool TestThirdPowerTableEven() //test 30
// {
//     int N = 7;
//     int N2 = N / 2;             // 2 4  6   8   10
//     int[] A = { 8, 64, 216 }; // 8 64 216 512 1000
//     int[] B = ThirdPowerTableEven(N);
//     for (int i = 0; i < N2; i++)
//     {
//         if (A[i] != B[i])
//         {
//             return false;
//         }
//     }
//     return true;
// }

// int[] Th_Ev = ThirdPowerTableEven(10);
// PrintArray(Th_Ev);
// if (TestThirdPowerTableEven()) { Console.WriteLine("Программа прошла тест."); }
// else { Console.WriteLine("Программа не прошла тест."); }

// 31.Задать массив из 8 элементов и вывести их на экран 
// int[] EightElements()
// {
//     int[] A = new int[8];
//     for (int i = 0; i < 8; i++)
//     {
//         A[i] = new Random().Next(1, 100);
//     }
//     return A;
// }

// bool TestEightElements() //test 31
// {
//     int[] A = EightElements();
//     int L = A.Length;
//     if (L == 8) { return true; }
//     else { return false; }
// }

// int[] A = EightElements();
// PrintArray(A);
// if (TestEightElements()) { Console.WriteLine("Программа прошла тест."); }
// else { Console.WriteLine("Программа не прошла тест."); }

// 32.Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// int[] ArrayOneZero()
// {
//     int[] eight = new int[8];
//     for (int i = 0; i < 8; i++)
//     {
//         eight[i] = new Random().Next(0, 2);
//     }
//     return eight;
// }

// bool TestArrayOneZero() //test 31
// {
//     int[] A = ArrayOneZero();
//     int L = A.Length;
//     bool flag;
//     if (L == 8) { flag = true; }
//     else { return false; }
//     for (int i = 0; i < 8; i++)
//     {
//         if (A[i] != 0 & A[i] != 1) { return false; }
//     }
//     return flag;
// }

// int[] A = ArrayOneZero();
// PrintArray(A);
// if (TestArrayOneZero()) { Console.WriteLine("Программа прошла тест."); }
// else { Console.WriteLine("Программа не прошла тест."); }
