﻿string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
+ "ежелт бы вас послали вместо нашего милого Винценгероде, "
+ "вы бы взяли приступомсогласие прусского короляю. "
+ "Вы так красноречивы. Вы дадите мне чаю? ";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);