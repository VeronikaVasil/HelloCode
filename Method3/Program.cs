//Вид3
//Обязателен оператор return
// Метод, который что-то возвращает, но ничего не принимает

int Method3()

{
    return DateTime.Now.Year; //в теле метода произошла какая-то работа
}

int year = Method3();
Console.WriteLine(year);

