// See https://aka.ms/new-console-template for more information
using RainCat;

Console.WriteLine("Hello, World!");
Cat[] cats= new Cat[3];
Cat persik = new Cat();
persik.Nick = "Персик";
persik.Year = 2;
persik.breed = "Британец";
Cat pushok = new Cat();
pushok.Nick = "Пушок";
pushok.Year = 3;
pushok.breed = "Немец";
Cat charlis = new Cat();
charlis.Nick = "Чарлис";
charlis.Year = 4;
charlis.breed = "Сиамец";

cats[0] = persik;
cats[1] = pushok;
cats[2] = charlis;

Controller controller = new Controller();
controller.Save(cats);
string path = "cats.json";
var t = controller.Load(path);
foreach (var item in t)
{
    Console.WriteLine(item.Nick,item.Year,item.breed);
}
