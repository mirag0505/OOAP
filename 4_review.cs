Надо было добавлять методы смотря на прошлое решение

1) не додумался добавить эти методы
// команды
// предусловие: i лежит в допустимых границах массива; 
// постусловие: значение элемента i изменено на value
public void put(i, T value);

// предусловие: i лежит в допустимых границах массива; 
// постусловие: перед элементом i добавлен 
// новый элемент с значением value; 
public void put_left(i, T value);

// предусловие: i лежит в допустимых границах массива; 
// постусловие: после элемента i добавлен 
// новый элемент с значением value;
public void put_right(i, T value);

и запрос

public int size(); // текущий размер массива 

2) i лежит в допустимых границах массива;
правильнее указываать диапазон границ, а не просто пустой или полный