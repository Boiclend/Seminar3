Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99999) {
    Console.WriteLine($"Число {number} не может быть палиндромом");
    return;
}
int LastNum = number % 10;
int SecondLastNum = number % 100;
SecondLastNum = SecondLastNum / 10;
int FindFirstNum = number / 1000;
int FirstNum = FindFirstNum / 10;
int SecondFirstNum = FindFirstNum % 10;

if (FirstNum == LastNum && SecondFirstNum == SecondLastNum) {
    Console.WriteLine($"Число {number} является палиндромом");
} else {
    Console.WriteLine($"Число {number} не является палиндромом");
}

