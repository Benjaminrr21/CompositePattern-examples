using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class File : DataStorage
    {

        public string Name { get; set; }
        public int Size { get; set; }
        public string Location { get; set; }
        public string Extension { get; set; }
        public File(string name,int size, string location, string extension)
        {
            Name = name;
            Size = size;
            Location = location;
            Extension = extension;
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
            Console.WriteLine($"Fajl je preimenovan iz {currentName}.{Extension} u {newName}");
        }

        public void View()
        {
            Console.WriteLine($"Naziv: {Name}.{Extension}\nVelicina:{Size}\nLokacija:{Location}\n");
            //Console.ReadKey();

        }
    }
}
