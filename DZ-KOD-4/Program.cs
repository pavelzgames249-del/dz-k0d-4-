using System.Reflection.Metadata;

void hello()
{
    Console.WriteLine("hello world");
}
hello();
hello();
hello();

void greet(string name)
{
    Console.WriteLine("привет "+ name);
}
greet("паша");
greet("саша");
greet("настя");

void Printperson(string name, int age, string city)
{
    Console.WriteLine($"имя: {name}. возраст: {age}. город: {city}.");
}
Printperson("Егор", 22, "Токио");
Printperson("Наталия", 17, "село молочное");

void PrintPerson(string name, int age = 18, string hobbi = "не указано")
{
    Console.WriteLine($"имя: {name}. возраст: {age}. хобби: {hobbi}");
}
PrintPerson("Алексей", 55, "создание GTA 7 на бинaрном коде");
PrintPerson("Мария");

int square(int x)
{
    return x * x;
}
Console.WriteLine(square(5));

Console.WriteLine("калькулятор: ");
Console.Write("введи первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("введи второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введи действие: + - * /  : ");
string fd = Console.ReadLine();
double add (double a, double b)
{
    return a + b;
}

double subtract (double a, double b)
{
    return (a - b);
}

double multiply (double a, double b)
{
    return a * b;
}

double divide (double a, double b)
{
    return a / b;
}

if (fd == "+") { Console.WriteLine(add(a,b)); }
else if (fd == "-") { Console.WriteLine(subtract(a, b)); }
else if (fd == "*") { Console.WriteLine(multiply(a,b)); }
else if (fd == "/" && b == 0) { Console.WriteLine("иди на небеса так нельзяяяяя"); }
else if (fd == "/") { Console.WriteLine(divide(a,b)); }
else { Console.WriteLine("такого значения нету "); }

int counter = 0;
void cvan()
{
    counter++;
}
cvan();
cvan();
cvan();
Console.WriteLine(counter);

int mily1(int a, int b){ return a * b; } 
int mily2(int a, int b, int c) { return a * b * c; }
double mily3(double a, double b) { return a * b; }

Console.WriteLine(mily1(9,9));
Console.WriteLine(mily2(9,9,9));
Console.WriteLine(mily3(2.5,2.5));

