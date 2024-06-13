АТД HashTable

abstract class HashTable<T>

// конструктор
// постусловие: создана пустая очередь
public HashTable<T> HashTable(int capacity = 10);

// команды
// предусловие: хеш-таблица не полная, хеш от этого значения не существует в таблице
// постусловие: добавить новой элемент
public void put(T value);

// предусловие: хеш-таблица не пуста;
// постусловие: удалён элемент с данным значением
public void remove(T value);

// предусловие: хеш-таблица не пуста;
// постусловие: сущесвует элемент с данным значением
public bool find(T value);

// запросы
public int size(); // текущий размер хеш-таблицы

// запросы статусов (возможные значения статусов)
public int get_put_status(); // успешно; очередь пуста
public int get_remove_status(); // успешно; очередь пуста
public int get_find_status(); // успешно; очередь пуста
public int get_size_status(); // успешно; очередь пуста