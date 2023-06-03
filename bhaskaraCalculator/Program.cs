menu:
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|                Bhaskara Calculator                  |");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|                x = -b ± √b² - 4.a.c                 |");
Console.WriteLine("|               -----------------------               |");
Console.WriteLine("|                         2.a                         |");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|               Do you want to calculate?             |");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|                        y or n                       |");
Console.WriteLine("|-----------------------------------------------------|");
Console.Write("R= ");
string res = Convert.ToString(Console.ReadLine());

switch (res)
{
    case "y":
    case "Y":
        goto valueSelect;
        break;

    case "n":
    case "N":
        Console.Clear();
        Environment.Exit(0);
        break;
    default:
        Console.Clear();
        Console.WriteLine("Invalid input.");
        Console.WriteLine("press any key to try again");
        Console.ReadKey();
        goto menu;
        break;
}

valueSelect:
Console.Clear();
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("                x = -b ± √b² - 4.a.c                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine("                         2.a                         ");
Console.WriteLine("|-----------------------------------------------------|");
Console.Write("Enter an int value for A: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 0)
{
    Console.Clear();
    Console.WriteLine("|-----------------------------------------------------|");
    Console.WriteLine("|               Invalid value for A                   |");
    Console.WriteLine("|-----------------------------------------------------|");
    Console.WriteLine($"                      A = {a}                       ");
    Console.WriteLine("|-----------------------------------------------------|");
    Console.WriteLine("|              Press any key to continue              |");
    Console.WriteLine("|-----------------------------------------------------|");
    Console.ReadKey();
    goto menu;
}
else
{

}


Console.Clear();
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"                x = -b ± √b² - 4.{a}.c                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         2.{a}                         ");
Console.WriteLine("|-----------------------------------------------------|");
Console.Write("Enter an int value for B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"                x = -{b} ± √{b}² - 4.{a}.c                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         2.{a}                         ");
Console.WriteLine("|-----------------------------------------------------|");
Console.Write("Enter an int value for C: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"                x = -{b} ± √{b}² - 4.{a}.{c}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         2.{a}                         ");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|                    let's calcule!                   |");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|              Press any key to continue              |");
Console.WriteLine("|-----------------------------------------------------|");
Console.ReadKey();

Console.Clear();
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"                x = -{b} ± √{b}² - 4.{a}.{c}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         2.{a}                         ");
Console.WriteLine("|-----------------------------------------------------|");
int respb = b * b;
int respDiv = 2 * a;
Console.WriteLine($"                x = -{b} ± √{respb} - 4.{a}.{c}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         {respDiv}                         ");
Console.WriteLine("|-----------------------------------------------------|");

int respMulti = a * c;
Console.WriteLine($"                x = -{b} ± √{respb} - 4.{respMulti}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         {respDiv}                         ");
Console.WriteLine("|-----------------------------------------------------|");


int respMulti2 = 4 * respMulti;
Console.WriteLine($"                x = -{b} ± √{respb} - {respMulti2}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         {respDiv}                         ");
Console.WriteLine("|-----------------------------------------------------|");

int respSub = respb - respMulti2;
Console.WriteLine($"                x = -{b} ± √{respSub}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         {respDiv}                         ");
Console.WriteLine("|-----------------------------------------------------|");

if (respSub <= 0)
{
    Console.WriteLine("|                    Invalid Square                   |");
    Console.WriteLine("|-----------------------------------------------------|");
    Console.WriteLine($"                      √{respSub}                   ");
    Console.WriteLine("|-----------------------------------------------------|");
    Console.WriteLine("|              Press any key to continue              |");
    Console.WriteLine("|-----------------------------------------------------|");
    Console.ReadKey();
    goto menu;
}
else
{

}

decimal respRaiz = Convert.ToDecimal(Math.Sqrt(respSub));
Console.WriteLine("|                        Result                       |");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"                x = -{b} ± {respRaiz}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         {respDiv}                         ");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|              Now let's calculate X1 and X2          |");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|              Press any key to continue              |");
Console.WriteLine("|-----------------------------------------------------|");
Console.ReadKey();

x1andX2:
Console.Clear();
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"                x = -{b} ± {respRaiz}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         {respDiv}                         ");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|                          X1                         |");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"                x1 = -{b} + {respRaiz}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         {respDiv}                         ");

decimal respX11 = -b + respRaiz;
Console.WriteLine($"                x1 = {respX11}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         {respDiv}                         ");

decimal respX12 = respX11 / respDiv;
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"                    X1 = {respX12}                       ");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|              Press any key to continue              |");
Console.WriteLine("|-----------------------------------------------------|");
Console.ReadKey();

Console.Clear();
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"                x = -{b} ± {respRaiz}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         {respDiv}                         ");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"                    X1 = {respX12}                       ");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|               Now let's calculate X2                |");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|              Press any key to continue              |");
Console.WriteLine("|-----------------------------------------------------|");
Console.ReadKey();

Console.Clear();
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"                x = -{b} ± {respRaiz}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         {respDiv}                         ");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|                          X2                         |");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"                x2 = -{b} - {respRaiz}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         {respDiv}                         ");

decimal respX21 = -b - respRaiz;
Console.WriteLine($"                x2 = {respX21}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         {respDiv}                         ");

decimal respX22 = respX21 / respDiv;
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"                    X2 = {respX22}                       ");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|              Press any key to continue              |");
Console.WriteLine("|-----------------------------------------------------|");
Console.ReadKey();

Console.Clear();
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|                Bhaskara Calculator                  |");
Console.WriteLine($"                x = -{b} ± {respRaiz}                 ");
Console.WriteLine("               -----------------------               ");
Console.WriteLine($"                         {respDiv}                         ");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine($"               X1 = {Convert.ToDecimal(respX12).ToString("0.0000000000000000")} and X2 = {Convert.ToDecimal(respX22).ToString("0.0000000000000000")}");
Console.WriteLine("|-----------------------------------------------------|");
Console.ReadKey();
Console.Clear();
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|                      Recalcule ?                    |");
Console.WriteLine("|-----------------------------------------------------|");
Console.WriteLine("|                        y or n                       |");
Console.WriteLine("|-----------------------------------------------------|");
Console.Write("R= ");
string recalcule = Convert.ToString(Console.ReadLine());

switch (res)
{
    case "y":
    case "Y":
        goto valueSelect;
        break;

    case "n":
    case "N":
        Console.Clear();
        Environment.Exit(0);
        break;
    default:
        Console.Clear();
        Console.WriteLine("Invalid input.");
        Console.WriteLine("press any key to try again");
        Console.ReadKey();
        goto menu;
        break;
}


