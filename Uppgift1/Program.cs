Console.Write("Ord: ");
string input1 = Console.ReadLine();
if(input1.Length > 9)
{
    input1 = input1.Substring(0, 9);
}
Console.Write("Antal upprepningar: ");
int input2 = int.Parse(Console.ReadLine());
switch(input2)
{
    case > 9:
    input2 = 9;
    break;

    case < 1:
    input2 = 1;
    break;

    default:
    break;
}

for(int i = 1; i <= input2; i++)
{
    Console.Write(input1);
}