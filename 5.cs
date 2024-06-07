АТД Queue

abstract class Queue<T>

// конструктор
public Queue<T> Queue();

// команды

// предусловие: очередь не полная;
// постусловие: вставлен новый элемент в хвост очереди
public void enqueue(T itm)

// предусловие: очередь не пустая;
// постусловие: возвращает элемент из головы очереди, удаляя его
public void dequeue()

// запросы
// постусловие: получено количество элементов очереди
public T size(int index)

// запросы статусов
public int get_enqueue_status(); // успешно; очередь полная
public int get_dequeue_status(); // успешно; очередь пустая
public int get_size_status();