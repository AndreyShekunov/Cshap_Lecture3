// Задача на создание программы обработки текста с помощью Методов и цикла for

//======= Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К", а маленькие "с" заменить
// большими "С".

// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = “qwerty”
//             012345
// s[3] // символ "r"

// Метод будет принимать строку и те смиволы которые нужно будет менять, 
// т.е старый символ и тот на который нужно заменить. Возвращаться будет срока.
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // пустая строковая переменная result

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }

    return result; // возврат результата из данного Метода Replace
}
// вывод метода Replace
string newText = Replace(text, ' ', '|'); // с помощью метода Replace заменяем пробелы черточками |
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К'); // используем тот же метод только меняем "к" на "К"
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С'); // используем тот же метод только меняем "с" на "С"
Console.WriteLine(newText);