using LIFO;

Lifo lifo = new Lifo();
for (int i = 0; i < 5; i++)
{
    lifo.Push(i);
}
Console.WriteLine(lifo.Get());

foreach (int i in lifo.stack)
{
    Console.WriteLine(i);
}