// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] UserArray(){
    System.Console.Write("Введите количество чисел: ");
    int len = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[len];
    for(int i = 0; i < len; i++){
        System.Console.Write($"Введите {i+1}-e число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int MoreZeroCount(int[] array){
    int counter = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] > 0) counter++; 
    }
    return counter;
}

int[] arr = UserArray();
System.Console.WriteLine($"Вы ввели {MoreZeroCount(arr)} чисел больше нуля");