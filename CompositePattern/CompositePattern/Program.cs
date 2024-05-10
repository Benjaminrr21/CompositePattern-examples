using System;
using System.Collections.Generic;
namespace CompositePattern
{
    /// <summary>
    /// Composite Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Folder main = new Folder("Moj folder", 200, "C:/Users/Desktop");
            File fileLeaf = new File("rezultati", 100, "C:/Users/Documents", "pdf");
            Folder subfolder = new Folder("SubFolder", 300, "C:/Users/Desktop");
            main.Add(fileLeaf);
            main.Add(subfolder);
            File file1 = new File("file1", 150, "C:/Users/Desktop", "docx");
            File file2 = new File("file2", 160, "C:/Users/Desktop", "jpg");
            subfolder.Add(file1);
            subfolder.Add(file2);

            //Operacija nad listom 
            Console.WriteLine("Operacije nad listom (jedinstvenim objektom):");
            fileLeaf.Rename("Novo ime");
            fileLeaf.Copy("D:/Files");
            fileLeaf.View();

            //Operacija nad grupom (stablom)
            Console.WriteLine("Operacije nad grupom (novim stablom):");
            subfolder.Rename("Subfolder 2 - Novo ime");
            subfolder.Copy("D:/MyDocs");
            subfolder.View();
            Console.ReadKey();
        }
    }
}