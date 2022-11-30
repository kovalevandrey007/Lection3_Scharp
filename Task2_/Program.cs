/* Дан текст. В тексте нужно заменить все пробелы 
черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменисть маленькими. 
*/

//Дан текст:
string text = "- Я думаю , - сказал князь, улыбаясь, - что, "
                 + "ежели бы вас послали "
                 + "вы бы взяли приступом согласие "
                 + "Вы так красноречивыю Вы дадите мне чаю?";

//string s = "qwerty"
//                  01234
//s[3] - это 
//указываем конкретный символ char (char oldValue меняем на newoldValue)
string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;   //так выглядет инициализация пустой строки
    int lenght = text.Lenght; //Обращение к свойству показывающее символов в строке
    for (int i = 0; i <length; i++)
    {
        if (text[i] == oldValue) result = result+ $"{newValue}"; //Если текс [i] совпал с тем символом, который мы хотим заменить, то в результат новое значение в виде строки newValue 
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, ' к', 'К');
Console.WriteLine(newText);