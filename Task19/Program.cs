int Print(string message) {
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int NUMBER = Print("Введите число");

if (NUMBER> 99999) {
    Console.WriteLine($"Число {NUMBER} не может быть палиндромом");
    return;
}

GetResult(NUMBER);

void GetResult(int number) {
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
}
