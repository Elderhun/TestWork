***Данный файл описывает работу программы для итоговой проверочной работы.***
==

# **Задача:** *Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на страте выполнения алгоритма.*
**При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**

# *Блок схема будет приложена в репозитории.*
---

## Далее описание кода по строкам.

## **1 Этап: создание массива из заданых символов, далее будем работать с ним.**


>2 Даем имя методу, прописываем тело.

>4 Создаем строку, и присваеваем ей символы из которых будем создавать массив.

>5 Создаем переменную в которую передадим рандом.

>6 Делаем переменную которая будет отвечать за позицию символа в переменной *resource*.

>7 Создаем массив типа стринг с рандомным размером.

>9 Прописываем цикл который будет отвечать за перемещение по массиву через индекс.

>11 Создаем пустую переменную типа стринг.

>13 Прописываем цикл который будет отвечать за создание элемента с рандомным кол-вом символов.

>16 Присваеваем переменной *position* случайное число.

>17 Записываем в пустую строку *strEmp* символ из строки resource с индексом *position*.

- Проходим цикл и записываем символы в строку *strEmp* до тех пор, пока j меньше случайно заданного числа.

- - После всех проходов возвращаемся в освновной цикл где происходит переход на следующий индекс массива.

**По завершению основного цикла возвращаем полученный массив *return strMass*.**

---

## **2 Этап: Закладываем размер будущего нового массива**

>29 Создаем две переменные: строковую и целочисленную.

- Строковая будет прнимать в себя элемент массива.

- Целочисленная будет отвечать за будущий размер нашего массива.

>31 Создаем цикл, будем переберать все элементы массива.

>33 Передаем в пустую строку элемент.

>35 Задаем условие, при положительном результате которого, будет увеличиваться размер нашего будущего массива.

>37 *True* увеличиваем переменную size на единицу.

>3 Этап: *Создание и заполнение нового массива*

**По завершению работы цикла, в переменной будет запись о будущем размере массива**

---

## **3 Этап: Создаем новый массив из условий задачи.**

>42 Прописываем имя нашего метода. На вход примет изначальный массив из 1 Этапа.

>44 В теле задаем пустую строку.

>46 Создаем массив и задаем в нем размер который нашли на 2 Этапе.

>47 Задаем переменную которая будет отвечать за позицию элемента в новом массиве.

>49 Прописываем цикл в котором будем перебирать каждый элемент массив с 1 Этапа.

>51 Передаем строковой переменной элемент массива.

>53 Прописываем условие в котором будем проверять элемент на соответствие с условием задачи.

>55 Если условие срабатывает, записываем рассматриваемый элемент в новый массив.

>56 Увеличиваем позицию.

**После выхода с цикла возвращаем новый массив return nStringArr.**

Вызываем методы, затем скрепляем при помощи *Join* и выводим результаты.

---

>>## Создали репозиторий, файл Readme. В нем сделали описание работы программы сопровождая коммитами и пушами на гитхаб.


## <span style='color:green'>**Конец :)** </span>
![Nyan-cat](https://i0.wp.com/www.printmag.com/wp-content/uploads/2021/02/4cbe8d_f1ed2800a49649848102c68fc5a66e53mv2.gif?fit=476%2C280&ssl=1)
