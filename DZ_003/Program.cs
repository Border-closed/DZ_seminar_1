Console.WriteLine ("Введите число:   ");
int A = Convert.ToInt32 (Console.ReadLine());
if (A % 2 == 0)
{
    Console.WriteLine (A + "  Ура, число четное!");
}
else
{
    Console.WriteLine (A + "  Число нечетное!");
}