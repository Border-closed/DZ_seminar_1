Console.WriteLine ("Введите первое число ");
int A = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число ");
int B = Convert.ToInt32 (Console.ReadLine());
int max = A;
if (B > max)
{
    Console.Write(B);
    Console.Write(" больше ");
    Console.WriteLine(A);
    }
else
{
    Console.Write(A);
    Console.Write(" больше ");
    Console.WriteLine(B);
}