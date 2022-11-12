Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "maga")
{
    Console.WriteLine("Salam, Maga");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}