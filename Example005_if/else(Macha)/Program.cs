// * Начало
// *Ввести имя пользователя
// *ЕСЛИ имя пользователя совпадает с "Маша" то...
// * поприветсвовать по особенному
// *ИНАЧЕ поприветсвовать по обычному
// *Конец


Console.WriteLine("Введите имя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")   //ToLower - команда позволяет переводить символы в нижный регистр
{
    Console.WriteLine("Ура это, Маша!");
}
else 
{
    Console.Write("Привет, "); 
    Console.WriteLine(username);
}