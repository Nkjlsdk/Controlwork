// Задать массив из строк, вывести массив с элементами длина которых меньше или равна 3 символам

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine()); //Переменная size размера массива
                                               
string [] array = new string[size];// создали массив размера size

for (int i = 0; i < size; i++) // заполнение массива от  i до размера size
{
 Console.WriteLine("Введите элемент массива:");
  array[i] = Console.ReadLine(); //заполяем массив с консоли   
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");//Вывели массив строк

int sizeresult = 0;
for (int i = 0; i < size; i++)
{

    if (array[i].Length <= 3)
    {

        sizeresult = 1 + sizeresult;//определили размер итогового массива

    }

}
if (sizeresult == 0)//проверка на наличие элементов заданным условиям
{
    Console.WriteLine($"Нет элементов длина которых меньше или равна 3");//вывод сообщения, 
                                            //что нет элементов соответствующих заданному условию
}
else
{
    string[] arrayresult = new string[sizeresult];//создание массива для вывода результата
 int j = 0;
for (int i = 0; i < size; i++)
{

    if (array[i].Length <= 3)//проверка элементов заданного масива на заданное условие
    {
       
            arrayresult[j] = array[i];//заполнение массива результата

j++;
        }

    }

Console.WriteLine($"Result: [ {String.Join("; ", arrayresult)} ]");//вывод массива

}
