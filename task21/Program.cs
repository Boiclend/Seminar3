int Zapros(string message) {
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int X1 = Zapros("Введите координату точки x1");
int Y1 = Zapros("Введите координату точки y1");
int Z1 = Zapros("Введите координату точки z1");
int X2 = Zapros("Введите координату точки x2");
int Y2 = Zapros("Введите координату точки y2");
int Z2 = Zapros("Введите координату точки z2");

GetResult(X1,Y1,Z1,X2,Y2,Z2);

void GetResult(int x1, int y1, int z1, int x2, int y2, int z2) {
    double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    Console.WriteLine(result);
}


