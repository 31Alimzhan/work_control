# work_control



![Блок схема программы](001.jpg)


Программа работает следующим образом

1. в программе есть основной блок
2. в программе есть 2 метода первый для генерации массива стринг
второй для поиска значений элементов массива с длиной менее или раной трем.
3. изначально вызывается первый метод генерации массива. так как метод string то он возвращает данные функцией return (возвращает массив)
в данном методе организуется цикл от 0 до 10 и выводится сообщение о вводе данных, после ввода данных с клавиатуры данные конвыертируются в стриг переменную и присваиваются соответствующему i-тому элементу массива 
плосле оконцания работы цикла метод возвращает массив.

4. затем вызывается метод void 
в этом методе также оргинизуется цикл с итерацией от 0 до конца массива.
также задается условие если длина жлемента массива меньше или равна 3м то этот элемент выводится на экран.

5. по оконцании раюботы второго метода программа заканчивает свою работу

6. все комментари даны для каждой строки в теле программы.
7. во втором методе вводится новая string переменная l которой присваивается элемент массива, затем соответствующей командой l.Length вычисляется длина элемента и значение присваивается переменной т где и происходит проверка на соответствующее условие (n<4).

Надеюсь все понятно объяснил