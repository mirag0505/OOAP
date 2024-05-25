Добавить аргумент в конструктор
Дефолтное значение 32
При пуше проверить, что стек не переполнен
А как проверять? У меня нету метода для этого? Это будет команда или запрос?
Мне нужен запрос на проверку указанного размера стека, и текущее количество элементов

А что делать, если переполнен? Вернуть статус ошибки PUSH? Таких статусов еще нету.

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
public void checkSizeStack();

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