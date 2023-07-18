Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result;
for (int i = 1; i < number + 1 ; i++) {
    result = i;
    result = result * result * result;
    Console.WriteLine(result);
}
