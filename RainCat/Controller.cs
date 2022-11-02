using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RainCat
{
    internal class Controller
    {
     public void Save(Cat[] cats)
     {
            var json = JsonSerializer.Serialize<Cat[]>(cats);
            File.WriteAllText("cats.json", json);
     }
     public Cat[] Load(string path)
        {
            path = "cats.json";
            if (!File.Exists(path))
            {
                return null;
            }
            else
            {
                var json = File.ReadAllText(path);
                Cat[] cats = JsonSerializer.Deserialize<Cat[]>(json);
                return cats;
            }
        }

    }

    
}
