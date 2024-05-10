using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public interface DataStorage
    {
         void Copy(string newLocation);
         void Rename(string newName);
         void Delete();
         void View();

    }






}
