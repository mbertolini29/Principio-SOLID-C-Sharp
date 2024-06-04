using System.Collections.ObjectModel;

namespace SingleResponsability
{
    //fake storage? -> almacenamiento falso
    //nos brinda una interfaz generica..
    //para poder manejar informacion en memoria.
    //nos ayuda a administrar las colecciones de datos..
    //para no tener que utilizar una base de datos como tal.
    public class FakeStorage<T>
    {
        private ObservableCollection<T> collection;

        public FakeStorage()
        {
            collection = new ObservableCollection<T>();
        }

        public T Add(T item)
        {
            collection.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            collection.Remove(item);
            return item;
        }

        public IEnumerable<T> GetAll()
        {
            return collection;
        }
    }
}