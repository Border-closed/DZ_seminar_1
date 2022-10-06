Console.WriteLine("Введите число");
string N = Console.ReadLine ();
int N1 = int.Parse (N);
int size = 0-N1;
while (size <= N1)
{
    if (size%2==0)
    {
        Console.Write (size + ", ");
    }
    size = size +1;
}
