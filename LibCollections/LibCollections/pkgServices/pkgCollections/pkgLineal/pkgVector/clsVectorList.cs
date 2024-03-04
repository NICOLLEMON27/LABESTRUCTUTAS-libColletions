using LibCollections.pkgServices.pkgCollections.pkgLineal.pkgADT;
using LibCollections.pkgServices.pkgCollections.pkgLineal.pkgInterfaces;


namespace LibCollections.pkgServices.pkgCollections.pkgLineal.pkgVector
{
    public class clsVectorList<T> : clsADTVector<T>, iList<T> where T : IComparable<T>
    {
        public bool opAdd(T item)
        {
            throw new NotImplementedException();
        }
        public bool opInsert(int index, T item)
        {
            throw new NotImplementedException();
        }
        public bool opRemove(int idx, T item)
        {
            throw new NotImplementedException();
        }

        public clsVectorList(int capacity) { }
        public clsVectorList() { }
    }
}
