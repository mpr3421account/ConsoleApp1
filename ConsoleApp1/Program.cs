List<int> numeroFibo = new List<int>(){1, 1};

while (numeroFibo.Count <= 30)
{
    int numeroAnterior1 = numeroFibo[numeroFibo.Count- 1];
    int numeroAnterior2 = numeroFibo[numeroFibo.Count- 2];
    int item = numeroAnterior1+ numeroAnterior2;
    numeroFibo.Add(item);
    Console.WriteLine(item);
}
