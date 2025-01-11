string[] notas = {"A", "B", "C", "D", "E", "F", "G"};
string[] variacao = { "b", "#" };

Random rand = new Random();

int numRandom = rand.Next(0, notas.Length);
int variacaoRandom = rand.Next(0, 2);

if (notas[numRandom].Equals("B") || notas[numRandom].Equals("E")) 
{
    Console.WriteLine("Sua nota musical de hoje é: " + notas[numRandom]);
}
else{
    Console.WriteLine("Sua nota musical de hoje é: " + notas[numRandom] + variacao[variacaoRandom]);
}