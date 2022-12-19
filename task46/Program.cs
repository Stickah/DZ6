double[] massiv = new double[4];
Console.WriteLine("Вводите поочередно b1,k1,b2,k2");
for (int i=0; i<4;i++)
{massiv[i] = Convert.ToInt32(Console.ReadLine());
}
double X = (massiv[2]-massiv[0])/(massiv[1]-massiv[3]);
Console.WriteLine("кордината X точки пересечения "+(X));
double Y = massiv[1]*X+massiv[0];
Console.WriteLine("кордината Y точки пересечения "+(Y));