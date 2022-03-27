﻿// проверка простого числа

// Простое число — число, которое делится само на себя и на единицу.
// Есть много алгоритмов поиска простых чисел. Реализуйте один из самых лёгких.
// Проверьте введённое с клавиатуры целое число на признак простоты. 

// Чтобы закрепить знания, реализуйте эту задачу, используя цикл while.
// 1. Для начала пользователь вводит целое число.
// 2. Затем в цикле нужно перебрать все числа, начиная с 1, и до N — 1.
// 3. Входное число N при каждой итерации цикла нужно делить на число, которое получается в цикле с остатком. 
// 4. Если остаток от деления равен 0, значит, программа нашла делитель этого числа, и потому это число уже не может являться простым числом.
// 5. Если остаток от деления равен 0, то следует переменной bool, объявленной за рамками цикла, присвоить значение true.
// 6. Если после выхода из цикла значение переменной осталось false, значит, число простое. 
// Если значение переменной стало true — значит, был найден делитель, поэтому число не может считаться простым.

// Советы и рекомендации
// 1. Посмотрите на оператор деления с остатком в задаче 1.
// 2. Для проверки простоты чисел используйте простые числа — 3, 7, 37, 79, 173. 

// Что оценивается
// Программа выводит на экран, является ли число простым.
// Программа не зависает.


Console.WriteLine("Введите целое число.");
double N = double.Parse(Console.ReadLine());
double i = 2;
bool resalt = false;

 
    
while (i < N )

{
    if (N % i == 0)
    {
        resalt = true;
        break;
    }
        
    else
        resalt = false;
        i++;

}

if (N == 0)
    Console.WriteLine("Введено число 0. Введите другое число.");

else if (N == 1)
    Console.WriteLine("Число " + N + " простое");

else if (resalt == false)
    Console.WriteLine("Число " + N + " простое");

else if (resalt == true)
    Console.WriteLine("Найден делитель. Число " + N + " не простое");


Console.WriteLine();







