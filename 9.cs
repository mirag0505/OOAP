abstract class HashTable<T>

  // конструктор
  // постусловие: создана пустая хэш-таблица заданного размера
  public HashTable<T> HashTable(int sz);

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


abstract class PowerSet<T>

abstract class PowerSet<T> : HashTable<T>

// конструктор
public PowerSet<T> PowerSet(int size);

// постусловие: вернет пересечение текущего множества и set2
public void intersection(PowerSet<T> set2);

// постусловие: вернет объединение текущего множества и set2
public void union(PowerSet<T> set2);

// постусловие: вернет разница текущего множества и set2
public void difference(PowerSet<T> set2);

// постусловие: вернет результат содержится множество2 в множестве1
public bool issubset(PowerSet<T> set2);

public int get_intersection_status(); // успешно; не превышает размер ограниения
public int get_union_status(); // успешно; не превышает размер ограниения
public int get_difference_status(); // успешно; не превышает размер ограниения
public int get_issubset_status(); // успешно; не превышает размер ограниения