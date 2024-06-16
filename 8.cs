NativeDictionary

АТД ParentHashable

abstract class ParentHashable<T>

// конструктор
// постусловие: создана пустая хэш-таблица заданного размера
public ParentHashable<T> ParentHashable(int sz);

// команды
// предусловие: в таблице имеется свободный слот для value;
// постусловие: в таблицу добавлено новое значение
public void put(T value);

// предусловие: в таблице имеется значение value;
// постусловие: из таблицы удалено значение value
public void remove(T value);

// запросы
public bool get(T value); // содержится ли значение value в таблице

public int size(); // количество элементов в таблице

// запросы статусов (возможные значения статусов)
public int get_put_status(); // успешно; 
                             // система коллизий не смогла найти свободный слот для значения

public int get_remove_status(); // успешно; значения нету в таблице

АТД HashTable
abstract class HashTable<T> : ParentHashable<T>

// конструктор
public HashTable<T> HashTable();

АТД NativeDictionary
abstract class NativeDictionary<T> : ParentHashable<T>

// конструктор
// постусловие: создана пустой ассоциативный массив
public NativeDictionary<T> NativeDictionary();

// команды
// предусловие: в таблице имеется свободный слот для value;
// постусловие: в таблицу добавлено новое значение
public void put(string key, T value);

// предусловие: в таблице имеется значение value по ключу;
// постусловие: из таблицы удалено значение value value по ключу
public void remove(string key);

// запросы
public bool get(string key); // содержится ли значение value в таблице