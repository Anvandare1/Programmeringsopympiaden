int N = int.Parse(Console.ReadLine());
int tripplet = 6;
int iterations = 0;

while(tripplet < N)
{
    iterations++;
    //tripplet = ((1 + iterations) * ((1 + iterations) + 1) * ((1 + iterations) + 2) );
    tripplet = ((1 + iterations) * (2 + iterations) * (3 + iterations) );
}

Console.WriteLine(iterations);
