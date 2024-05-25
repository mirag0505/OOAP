Добавить аргумент в конструктор
Дефолтное значение 32
При пуше проверить, что стек не переполнен
А как проверять? У меня нету метода для этого? Это будет команда или запрос?
Мне нужен запрос на проверку указанного размера стека, и текущее количество элементов.
Не понимаю, как должен выглядеть метод, получается стек может переполниться, только если делать push.
Внутр метода через метод size() получать текущее количество элементов, 
а затем сравнивать больше ли это значение, чем длинна стека?

А что делать, если переполнен? Вернуть статус ошибки PUSH? Таких статусов еще нету. Добавим.
Но возвращать число тоже странно, exeption? Я так понял, что это не лучший выбор. 
Наверно, можно изначально в кнострукторе задавать длинну для стека, 
и в нем такая ошибка должна быть предусмотрена, ибо это выход за пределы стека.
Так сделать не выйдет. Наврено добавлю exeption, е могу придумать адекватное решение.

abstract class BoundedStack<T>

public const int POP_NIL = 0; // push() ещё не вызывалась
public const int POP_OK = 1; // последняя pop() отработала нормально
public const int POP_ERR = 2; // стек пуст

public const int PEEK_NIL = 0; // push() ещё не вызывалась
public const int PEEK_OK = 1; // последняя peek() вернула корректное значение 
public const int PEEK_ERR = 2; // стек пуст

public const int PUSH_NIL = 0; // push() ещё не вызывалась
public const int PUSH_OK = 1; // последний push() отработала нормально 
public const int PUSH_ERR = 2; // стек переполнен

// конструктор
public BoundedStack<T> BoundedStack(int count); // постусловие: создан новый пустой стек

// запрос:
// предусловие: стек не пустой; 
public int checkStackFull();

// команды:
// постусловие: в стек добавлено новое значение
public void push(T value);

// предусловие: стек не пустой; 
// постусловие: из стека удалён верхний элемент
public void pop();

// постусловие: из стека удалятся все значения
public void clear();


// предусловие: стек не пустой
public T peek();

public int size();

// дополнительные запросы:
public int get_pop_status(); // возвращает значение POP_*
public int get_peek_status(); // возвращает значение PEEK_*
public int get_push_status(); // возвращает значение PUSH_*

class Stack<T>

// скрытые поля
private List<T> stack; // основное хранилище стека
private int peek_status; // статус запроса peek()
private int pop_status; // статус команды pop()
private int push_status; // статус команды push()

// интерфейс класса, реализующий АТД Stack
public const int POP_NIL = 0;
public const int POP_OK = 1;
public const int POP_ERR = 2;

public const int PEEK_NIL = 0;
public const int PEEK_OK = 1;
public const int PEEK_ERR = 2;

public const int PUSH_NIL = 0;
public const int PUSH_OK = 1;
public const int PUSH_ERR = 2;

public void Stack(int size) // конструктор
    clear()

  public void push(T value)
    checkStackFull()
    stack.Append(value)

  public void pop()
    if size() > 0
      stack.RemoveAt(-1)
      pop_status = POP_OK
    else
    pop_status = POP_ERR

  public void clear()
    stack = [] // пустой список/стек

    // начальные статусы для предусловий peek() и pop()
    peek_status = PEEK_NIL
    pop_status = POP_NIL

  public T peek()
    if size() > 0
      result = stack[-1]
      peek_status = PEEK_OK
    else
      result = 0
      peek_status = PEEK_ERR
    return result

  public int checkStackFull()
    var size = size()

    if stack.Length === size {
      push_status = PUSH_ERR;
      throw new ArgumentOutOfRangeException("Недопустимый индекс массива");
    } else if size != 0 {
      push_status = PEEK_OK;
    }

  public int size()
    return stack.Length()

  // запросы статусов
  public int get_pop_status()
    return pop_status

  public int get_peek_status()
    return peek_status
    
  public int get_push_status()
    return push_status