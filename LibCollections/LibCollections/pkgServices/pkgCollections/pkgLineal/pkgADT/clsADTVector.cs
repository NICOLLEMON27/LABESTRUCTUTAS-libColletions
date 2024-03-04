using LibCollections.pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCollections.pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTVector<T> : clsADTLineal<T>, iADTVector<T> where T : IComparable<T>
    {
        int Capacity;
        T[] Items;

        public int opGetCapacity()
        {
            throw new NotImplementedException();
        }

        public clsADTVector() {
            this.Capacity = Capacity;
            this .Items = new T[100]; 
        }
        public clsADTVector(int Capacity)
        {
            this.Capacity = Capacity;
            this.Items = new T[100];
        }
    }
}
