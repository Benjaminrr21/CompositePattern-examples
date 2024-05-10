using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Folder : DataStorage
    {

        public string Name { get; set; }
        public int Size { get; set; }
        public string Location { get; set; }
        public List<DataStorage> Folders { get; set; }
        public Folder(string name, int size,string location)
        {
            Name = name;
            Size = size;
            Location = location;
            Folders = new List<DataStorage>();
        }


        public void Copy(string newLocation)
        {
            Console.WriteLine($"Folder {Name} je kopiran sa adrese {Location} na {newLocation}");
        }

        public void Delete()
        {
            Console.WriteLine($"Folder {Name} je izbrisan.");
        }

        public void Rename(string newName)
        {
            var currentName = Name;
            Name = newName;
            Console.WriteLine($"Folder je preimenovan iz {currentName} u {newName}");
        }
        public void Add(DataStorage s) {
        Folders.Add(s);
        }
        public void Remove(DataStorage s) {
        Folders.Remove(s);
        }

        public void View()
        {
            Console.WriteLine($"Naziv: {Name}\nVelicina:{Size}\nLokacija:{Location}\n\n");
            Console.WriteLine($"Fajlovi u folderu {Name}");
            foreach (var child in Folders)
            {
                child.View();
            }
            //Console.ReadKey();
        }
    }
}
