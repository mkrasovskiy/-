//Виды методов
//1 вид - ничего не принимают, ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор...");
}
//Вызов метода
//Method1();

//2 вид - что-то принимают, ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);

//3 вид - ничего не принимают, что-то возвращают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//4 вид - что-то принимают, что-то возвращают
/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);*/

string Method4(int count, string text)
{
    
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);
