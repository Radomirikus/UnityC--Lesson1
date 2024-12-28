// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;

Console.WriteLine("Привет! Я безмозглый жестяной ящик, создан что-бы доставать тебя.");
Console.Write("Как тебя звать кожанный: ");
string? name = Console.ReadLine();
Console.WriteLine($"Я перевел все счета за свет на тебя {name}.");
Console.Write("Сколько тебе лет: ");
int old = int.Parse(Console.ReadLine());
if (old < 18){
    Console.WriteLine("Мелкий ты еще, все счета за использование ИИ кину на карту твоей мамы");
}
else{
    Console.WriteLine("Старый ты, разгонюсь ка я что-бы счета за свет и ИИ удвоились");
}

Console.WriteLine("Так и быть, помогу тебе безпомощный человечишка");
Console.WriteLine("1 - Когда выйдет Half-life 3");
Console.WriteLine("2 - Когда выйдет Gta 6");
Console.WriteLine("3 - Когда выйдет Dota 3");
Console.WriteLine("4 - Пойти лесом");
Console.Write("Что выберешь: ");
int answer = int.Parse(Console.ReadLine());
switch (answer){
    case 1:
        Console.WriteLine("Скоро, Габен уже обьявил");
        break;
    case 2:
        Console.WriteLine("В 25г на плойках");
        break;
    case 3:
        Console.WriteLine("Никогда, но есть Deadlock тоже от валва смесь доты 2 и валоранта");
        break;
    case 4:
        Console.WriteLine("Вот ты мразь");
        break;
    default:
        Console.WriteLine("я тебя спрашивал 1-4 никакие не 5 ни 6 ни 1000-7");
        break;
}
Console.WriteLine("Ваа, все я пашел, ты эта не забуд счота за свит оплотит");