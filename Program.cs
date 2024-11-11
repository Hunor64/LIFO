using LIFO;

Lifo lifo = new Lifo();
for (int i = 0; i < 5; i++)
{
    lifo.Push(i);
}
Console.WriteLine(lifo.GetLength());

//lifo.Reverse();
foreach (int i in lifo.GetAll())
{
    Console.WriteLine(i);
}
Console.ReadLine();