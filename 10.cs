abstract class BloomFilter<T>
  // конструктор
  // постусловие: создан фильтр блума заданного размера
  public BloomFilter<T> BloomFilter(int sz);

// команды
// предусловие: в таблице имеется свободный слот для value;
// постусловие: в таблицу добавлено новое значение
public void add(string str1);

// предусловие: в таблице имеется значение value;
// постусловие: из таблицы удалено значение value
public bool isValue(string str1);

// запросы
public bool get(T value); // содержится ли значение value в таблице

public int size(); // количество элементов в таблице

// запросы статусов (возможные значения статусов)
public int get_add_status(); // успешно; 
                             // система коллизий не смогла найти свободный слот для значения

public int get_is_value_status(); // успешно; значения нету в таблице