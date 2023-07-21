int Print(string message) {
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int NUMBER = Print("Введите число");

GetResult(NUMBER);

void GetResult(int number) {
for (int i = 1; i < number + 1 ; i++) {
    int result = i;
    result = result * result * result;
    Console.WriteLine(result);
}
}