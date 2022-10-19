System.Console.WriteLine("Введите пятизначное число");
string s = Console.ReadLine(); 
int l = s.Length;
if (l == 5)
{
    Console.WriteLine($"проверка количества цифр в числе - {l}");
    Console.WriteLine($"{s}");
    if(s[0].ToString() == s[4].ToString()) 
        {
        if(s[1].ToString() == s[3].ToString())   
        System.Console.WriteLine("Введенное число является палиндромом");
        }
    else
    System.Console.WriteLine("Введенное число не является палиндромом");
}
else
{
    Console.WriteLine($"ошибка ввода - число не пятизначное: {s}");
}