var nomes = new List<string> { "Claudio", "Ana", "Felipe" };
nomes.Add("Paulo");


foreach(var nome in nomes)
{
    Console.WriteLine($"Olá {nome.ToUpper()}!");
}

Console.WriteLine($"Este nome  {nomes[1]} está na posição 1");

var index = nomes.IndexOf("Tadeu");
if(index == -1)
{
    Console.WriteLine($"Objeto não encontrado, IndexOf retornará {index}");
}
else
{
    Console.WriteLine($"O nome {nomes[index]} está na posição {index}");
}