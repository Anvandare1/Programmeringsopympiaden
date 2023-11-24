using Microsoft.VisualBasic;

int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

List<char> output = new List<char>();

List<string> lines = new List<string>();

for(int i =1; i <= n; i++)
{
    var inp = (Console.ReadLine());
    if(inp.Length > m)
    {
        lines.Add(inp.Substring(0, m));
    }   

    else
    {
        lines.Add(inp);
    }
}

int start = 0;
int iteration = 0;
for(int i = 0; i <= lines.Count - 1; i++)
{
    foreach(char c in lines[i])
    {
        iteration ++;
        if(iteration > m)
        {
            iteration = 1;
        }
        if(iteration >= start)
        {
           switch(c)
           {
               case '.':
               break;

               default:
                  output.Add(c);
                  start = iteration;
               break;
           }
        }
    }
}

for(int i = 0; i <= output.Count - 1; i++)
{
    Console.Write(output[i]);
}