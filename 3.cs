abstract class ParentList<T>

// конструктор
// постусловие: создан новый пустой список
public ParentList<T> ParentList();

// команды
// предусловие: список не пуст; 
// постусловие: курсор установлен на первый узел в списке
public void head();

// предусловие: список не пуст; 
// постусловие: курсор установлен на последний узел в списке
public void tail();

// предусловие: правее курсора есть элемент; 
// постусловие: курсор сдвинут на один узел вправо
public void right();

// предусловие: список не пуст; 
// постусловие: следом за текущим узлом добавлен 
// новый узел с заданным значением
public void put_right(T value);

// предусловие: список не пуст; 
// постусловие: перед текущим узлом добавлен 
// новый узел с заданным значением
public void put_left(T value);

// предусловие: список не пуст; 
// постусловие: текущий узел удалён, 
// курсор смещён к правому соседу, если он есть, 
// в противном случае курсор смещён к левому соседу,
// если он есть
public void remove();

// постусловие: список очищен от всех элементов
public void clear();

// постусловие: новый узел добавлен в хвост списка
public void add_tail(T value);

// постусловие: в списке удалены все узлы с заданным значением
public void remove_all(T value);

// предусловие: список не пуст;
// постусловие: значение текущего узла заменено на новое
public void replace(T value);

// постусловие: курсор установлен на следующий узел 
// с искомым значением, если такой узел найден
public void find(T value);

// запросы
public T get(); // предусловие: список не пуст
public bool is_head();
public bool is_tail();
public bool is_value();
public int size();

// запросы статусов (возможные значения статусов)
public int get_head_status(); // успешно; список пуст
public int get_tail_status(); // успешно; список пуст
public int get_right_status(); // успешно; правее нету элемента
public int get_put_right_status(); // успешно; список пуст
public int get_put_left_status(); // успешно; список пуст
public int get_remove_status(); // успешно; список пуст
public int get_replace_status(); // успешно; список пуст
public int get_find_status(); // следующий найден; 
                              // следующий не найден; список пуст
public int get_get_status(); // успешно; список пуст

LinkedList implementation ParentList<T>

TwoWayList implementation ParentList<T>

// предусловие: левее курсора есть элемент; 
// постусловие: курсор сдвинут на один узел влево
public void right();



class ParentList<T>

// скрытые поля
private List<T> list; // основное хранилище списка

private int head_status;
private int tail_status;
private int right_status;
private int put_right_status;

private int put_left_status;
private int tail_status;
private int head_status;
private int tail_status;

public int get_head_status();
public int get_tail_status();
public int get_right_status();
public int get_put_right_status();
public int get_put_left_status();
public int get_remove_status();
public int get_replace_status();
public int get_find_status();
public int get_get_status();

// интерфейс класса, реализующий АТД List
public const int INDEX = 0;
public const int HEAD_OK = 1;
public const int HEAD_ERR = 2;
public const int TAIL_OK = 1;
public const int TAIL_ERR = 2;

public const int RIGHT_OK = 1;
public const int RIGHT_ERR = 2;
public const int PUT_RIGHT_OK = 1;
public const int PUT_RIGHT_ERR = 2;
public const int PUT_LEFT_OK = 1;
public const int PUT_LEFT_ERR = 2;

public const int REMOVE_OK = 1;
public const int REMOVE_ERR = 2;
public const int REPLACE_OK = 1;
public const int REPLACE_ERR = 2;
public const int FIND_OK = 1;
public const int FIND_ERR = 2;

public const int GET_OK = 1;
public const int GET_ERR = 2;

public void ParentList() // конструктор
    clear()

// команды
public void head()
  INDEX = 0;
head_status = HEAD_OK;

public void tail()
  if (size > 0)
{
    INDEX = size();
    head_status = HEAD_OK;
}
else
{
    head_status = HEAD_ERR;
}


public void put_right(T value);

public void put_left(T value);

public void remove();

public void clear()
    list = []
    head();

public void add_tail(T value);

public void remove_all(T value);

public void replace(T value);

public void find(T value);

// запросы
public T get()
  return

public bool is_head();
return INDEX == 0;

public bool is_tail()
  return INDEX == size();

public bool is_value()
  return size() == 0;

public int size()
  return LinkedList.l()

// запросы статусов
public int get_head_status()
        return head_status;
public int get_tail_status()
        return tail_status;
public int get_right_status()
        return right_status;
public int get_put_right_status()
        return put_right_status;
public int get_put_left_status()
        return put_left_status;
public int get_remove_status()
        return remove_status;
public int get_replace_status()
        return replace_status;
public int get_find_status()
        return find_status;
public int get_get_status()
        return get_status;


LinkedList implementation ParentList<T>
// конструктор
public LinkedList<T> LinkedList();


TwoWayList implementation ParentList<T>

// конструктор
public TwoWayList<T> TwoWayList();
private int put_left_status;
public const int LEFT_OK = 1;
public const int LEFT_ERR = 2;

public void left()

public int get_left_status()
    return left_status;