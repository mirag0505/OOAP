DynArray
abstract class DynArray<T>

// конструктор
public ParentList<T> ParentList();

// команды
// предусловие: список не полный;
// постусловие: добавлен новый элемент в конец списка
public void append(T itm)

// предусловие: список не пуст; 
// постусловие: удален элемент с заданным индексом
public void remove(int index)

// предусловие: список не полный;
// постусловие: вставлен новый элемент в заданную позицию
public void insert(T itm, int index)

// мне не ясно, нужно ли добавлять метод увеличивающий размер массива или уменьшающий
// кажется, что это детали реализации

// запросы

// предусловие: список не пуст
// постусловие: получен элемент по индексу
public T get_item(int index)

// запросы статусов
public int get_append_status(); // успешно; список полный
public int get_remove_status(); // успешно; список пустой
public int get_insert_status(); // успешно; список полный
public int get_get_item_status(); // успешно; список пуст