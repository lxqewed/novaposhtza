// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8; // для укр. тексту
Console.WriteLine("--------- Welcome ---------");

Console.WriteLine("--------- Меню ---------");
Console.WriteLine("--------- 1. Послуги ---------");
Console.WriteLine("--------- 2. Редагувати послуги ---------");
Console.WriteLine("--------- 3. Прийом замовлень ---------");
Console.WriteLine("--------- 4. Виконання замовлення ---------");
Console.WriteLine("--------- 5. Збереження замовлень ---------");

public class Посилка
{
    public string Назва { get; set; }
    public string Адреса { get; set; }
    public string Отримувач { get; set; }
    public string Відправник { get; set; }
    public double Вага { get; set; }
    public double Ціна { get; set; }



