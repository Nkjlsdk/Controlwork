// Задать массив из строк, вывести массив с элементами длина которых меньше или равна 3 символам

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine()); 
                                               
string [] array = new string[size];

for (int i = 0; i < size; i++) 
{
 Console.WriteLine("Введите элемент массива:");
  array[i] = Console.ReadLine(); 
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

int sizeresult = 0;
for (int i = 0; i < size; i++)
{

    if (array[i].Length <= 3)
    {

        sizeresult = 1 + sizeresult;
    }

}
if (sizeresult == 0)
{
    Console.WriteLine($"Нет элементов длина которых меньше или равна 3");
}
else
{
    string[] arrayresult = new string[sizeresult];
 int j = 0;
for (int i = 0; i < size; i++)
{

    if (array[i].Length <= 3)
    {
       
            arrayresult[j] = array[i];

j++;
        }

    }

Console.WriteLine($"Result: [ {String.Join("; ", arrayresult)} ]");

}
