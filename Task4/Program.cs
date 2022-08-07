Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= N)
{
    if ((i+2) > N) Console.WriteLine(i);
    else Console.Write(i + ", ");
    i += 2;
}