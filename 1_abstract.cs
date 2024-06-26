abstract class Stack<T>

public const int POP_NIL = 0; // push() ещё не вызывалась
public const int POP_OK = 1; // последняя pop() отработала нормально
public const int POP_ERR = 2; // стек пуст

public const int PEEK_NIL = 0; // push() ещё не вызывалась
public const int PEEK_OK = 1; // последняя peek() вернула корректное значение 
public const int PEEK_ERR = 2; // стек пуст

// конструктор
public Stack<T> Stack(); // постусловие: создан новый пустой стек


// команды:
// постусловие: в стек добавлено новое значение
public void push(T value);

// предусловие: стек не пустой; 
// постусловие: из стека удалён верхний элемент
public void pop();

// постусловие: из стека удалятся все значения
public void clear();


// запросы:
// предусловие: стек не пустой
public T peek();

public int size();


// дополнительные запросы:
public int get_pop_status(); // возвращает значение POP_*
public int get_peek_status(); // возвращает значение PEEK_*


Задание 1

На основе примера АТД Stack (но не в форме наследования, а как автономное решение) 
определите АТД BoundedStack и выполните его реализацию. BoundedStack -- это 
ограниченный стек, конструктор которого получает целое положительное значение, 
задающее максимально допустимое количество элементов в стеке. Если параметр 
не задан, конструктор по умолчанию формирует стек максимум на 32 элемента.

BoundedStack -- это весьма распространённая прикладная версия стеков, потому 
что на практике обычно нежелательно позволять стеку неограниченно расти.