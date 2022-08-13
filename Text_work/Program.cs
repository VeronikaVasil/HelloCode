// ====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками.
// Маленькие буквы "к" заменить большими "К"
// Большие буквы "С" заменить маленькими "с"

//Ясна ли задача?

string text = "- я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы знали приступом согласие прусского короля."
            + "Вы так красноречивы. Выдадите мне чаю?";
// string s = "qwerty"
//             012345
// s[3]  // r

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
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'В', 'в');
Console.WriteLine(newText);
