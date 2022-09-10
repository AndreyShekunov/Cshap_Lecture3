// Цикл For (цкл со счётчиком). Но нужно отметить все циклы взаимозаменяемые (for, while)
// 99% задач легко решаются с помощью цикла for

// подправим 4 Метод из Example012_1

string Method4(int count, string text)
{
    string result = String.Empty; // String.Empty означает "Пустая строка", можно заменить на " ".
    for(int i = 0; i < count; i++) // for(инициализация счетчика(int i = 0); проверка условия(i < count); инкримент(i++))
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);