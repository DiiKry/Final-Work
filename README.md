# Итоговая задача
## Задача : 
    Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
## Описание алгоритма решения:
> Объявляется два массива: изначальный и вторый такой же длины. 

> Объявляется метод, в котором цикл соразмерный длине массива, 

> (Внутри цикла) проверка условия ( <=3 ), если да элемент первого массива заносится в count элемент второго массива. 

> При помощи переменной count поочередно перемещаем элементы из первого массива во второй (без пробелов).

> Увеличиваем переменную count на 1

> Возвращаемся к циклу for в котором index увеличивается на 1. И так проверяется до конца.