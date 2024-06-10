АТД Deque

abstract class Deque<T>

  // конструктор
  // постусловие: создана пустая очередь
  public Deque<T> Deque();

// команды
// постусловие: в хвост очереди добавлен новый элемент
public void addTail(T value);

// предусловие: очередь не пуста;
// постусловие: из головы очереди удалён элемент
public void removeHead();

// команды
// постусловие: в голову очереди добавлен новый элемент
public void addHead(T value);

// предусловие: очередь не пуста;
// постусловие: из хвоста очереди удалён элемент
public void removeTail();

// запросы
// предусловие: очередь не пуста
public T getHead(); // получить элемент из головы очереди; 
public T getTail(); // получить элемент из хвоста очереди; 

public int size(); // текущий размер очереди

// запросы статусов (возможные значения статусов)
public int get_remove_head_status(); // успешно; очередь пуста
public int get_dequeue_tail_status(); // успешно; очередь пуста
public int get_get_head_status(); // успешно; очередь пуста
public int get_get_tail_status(); // успешно; очередь пуста